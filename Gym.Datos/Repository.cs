namespace Gym.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(MyDbContext context)
        {
            this.Context = context;
            this.ObjectSet = context.Set<T>();
        }

        protected MyDbContext Context;

        public DbSet<T> ObjectSet;

        public IEnumerable<T> GetAll() => this.ObjectSet;

        public IQueryable<T> GetQueryable() => this.ObjectSet;

        public virtual T GetById(object id) => this.ObjectSet.Find(id);

        public IEnumerable<T> Query(Expression<Func<T, bool>> filter) => this.ObjectSet.Where(filter);

        public void Add(T entity) => this.ObjectSet.Add(entity);

        public void Remove(T entity) => this.ObjectSet.Remove(entity);

        public void Detach(T entity) => this.Context.Entry(entity).State = EntityState.Detached;

        public void Edit(T entity) 
        {
            this.ObjectSet.Attach(entity);
            this.Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual bool ExistId(object id) => this.ObjectSet.Find(id) != null;
    }
}