namespace Gym.Controladora
{
    using System.Collections.Generic;

    public interface IController<T> where T : class
    {
        ICollection<T> Listar();

        T Obtener(int idEntity);

        void Guardar(T objeto, bool esModificacion);

        void Eliminar(int idEntity);
    }
}
