namespace Gym.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;        

        void Save();

        void Dispose();
    }
}
