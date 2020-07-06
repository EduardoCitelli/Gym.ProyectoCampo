using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace Gym.Datos
{
    public class UnitOfWorkSolver : IUnitOfWorkSolver
    {
        private readonly INombreRepositoryGenerator nombreRepositoryGenerator;
        private readonly Dictionary<string, object> repositories;

        public UnitOfWorkSolver(
            //IDbContextBuilder builder, 
            INombreRepositoryGenerator nombreRepositoryGenerator)
        {
            //this.Context = builder.GetObjectContext();
            this.nombreRepositoryGenerator = nombreRepositoryGenerator;
            this.repositories = new Dictionary<string, object>();
        }

        protected MyDbContext Context { get; }

        public void Commit()
        {
            try
            {
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            var nombre = this.nombreRepositoryGenerator.GetNombreRepository<T>();

            if (!this.repositories.ContainsKey(nombre))
            {
                var repo = this.CreateRepository<T>(nombre);
                this.repositories.Add(nombre, repo);
            }

            return this.repositories[nombre] as IRepository<T>;
        }

        public async Task<IEnumerable<T>> ObtenerPorSP<T>(string sql, params object[] parameters) where T : class => await this.Context.Database.SqlQuery<T>(sql, parameters).ToListAsync();

        public async Task<int> ExecuteSqlCommand(string sql, params object[] parameters)
        {
            this.Context.Database.CommandTimeout = 0;
            return await this.Context.Database.ExecuteSqlCommandAsync(sql, parameters);
        }        

        protected virtual IRepository<T> CreateRepository<T>(string nombre) where T : class => new Repository<T>(this.Context);
    }
}
