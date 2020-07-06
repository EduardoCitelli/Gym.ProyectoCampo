namespace Gym.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NombreRepositoryGenerator : INombreRepositoryGenerator
    {
        public string GetNombreRepository<T>()
        {
            var nombreClase = typeof(T).Name;
            return $"{nombreClase}Repository";
        }
    }
}
