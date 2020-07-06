namespace Gym.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Remove(T entity);
        
        void Edit(T Objeto);

        IEnumerable<T> GetAll();

        T GetById(object id);

        IEnumerable<T> Query(Expression<Func<T, bool>> filter);

        bool ExistId(object id);
    }
}