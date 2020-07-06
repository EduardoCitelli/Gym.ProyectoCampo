namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GestionarSocios : Gestionable<Socios>
    {
        public virtual ICollection<Socios> ListarActivos()
        {
            var repository = this.CrearRepository();

            var lista = repository.GetAll().Where(x => x.VerificarMembresia()).ToList();

            this.CerrarRepository();

            return lista;
        }
    }
}