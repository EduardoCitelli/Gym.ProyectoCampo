namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using System.Collections.Generic;
    
    public interface IGestionable<T> where T : class
    {        
        ICollection<T> Listar();

        T Obtener(int idEntity);
    }
}