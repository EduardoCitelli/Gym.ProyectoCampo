using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Datos
{
    public interface IUnitOfWorkSolver
    {
        void Commit();

        IRepository<T> GetRepository<T>() where T : class;
    }
}
