namespace Gym.Datos
{
    using System;
    using System.Collections.Generic;

    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly MyDbContext Context = new MyDbContext();

        private readonly NombreRepositoryGenerator nombreRepositoryGenerator;

        private readonly Dictionary<string, object> repositories;

        private bool disposed = false;

        public UnitOfWork()
        {
            this.nombreRepositoryGenerator = new NombreRepositoryGenerator();
            this.repositories = new Dictionary<string, object>();
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

        protected virtual IRepository<T> CreateRepository<T>(string nombre) where T : class => new Repository<T>(this.Context);            

        public void Save() => this.Context.SaveChanges();

        public void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
                if (disposing)
                    this.Context.Dispose();

            this.disposed = true;
        }        
    }
}