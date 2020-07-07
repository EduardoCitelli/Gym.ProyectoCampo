namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Linq;
    
    public class GestionarTipoMembresias : Gestionable<TipoMembresias>
    {
        public override ICollection<TipoMembresias> Listar()
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<TipoMembresias>();

            var lista = repository.GetAll().ToList();

            this.uow.Dispose();

            return lista;
        }

        public override TipoMembresias Obtener(int idTipoMembresia)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<TipoMembresias>();

            var tipoMembresia = repository.GetById(idTipoMembresia);

            this.uow.Dispose();

            return tipoMembresia;
        }

        public IEnumerable<TipoMembresias> ObtenerTiposMembresiasPorDescripcion(string descripcion)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<TipoMembresias>();

            var lista = repository.Query(x => x.tmm_Descripcion.Contains(descripcion)).ToList();

            return lista;
        }
    }
}
