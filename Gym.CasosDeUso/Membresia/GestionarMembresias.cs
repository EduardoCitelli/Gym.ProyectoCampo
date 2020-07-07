namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;    

    public class GestionarMembresias : Gestionable<Membresias>
    {
        public override ICollection<Membresias> Listar()
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Membresias>();

            var lista = repository.GetAll().AsQueryable().Include(x => x.Tipo).ToList();

            this.uow.Dispose();

            return lista;
        }

        public override Membresias Obtener(int idMembresia)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Membresias>();

            var membresia = repository.GetById(idMembresia);

            this.uow.Dispose();

            return membresia;
        }

        public ICollection<Membresias> ObtenerPorDescripcion(string descripcion)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Membresias>();

            var membresias = repository.Query(x => x.mem_Descripcion.Contains(descripcion)).AsQueryable().Include(x => x.Tipo).ToList();

            this.uow.Dispose();

            return membresias;
        }
    }
}