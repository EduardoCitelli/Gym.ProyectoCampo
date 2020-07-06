namespace Gym.CasosDeUso
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IOperable<T> where T : class
    {
        void Alta(T entity);

        void Eliminar(int idEntity);

        void Modificar(T entity);
    }
}