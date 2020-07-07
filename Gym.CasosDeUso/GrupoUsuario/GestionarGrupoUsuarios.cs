namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public partial class GestionarGrupoUsuarios : Gestionable<GrupoUsuarios>
    {
        public override ICollection<GrupoUsuarios> Listar()
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<GrupoUsuarios>();

            var lista = repository.GetAll().AsQueryable().Include(x => x.Users).ToList();

            this.uow.Dispose();

            return lista;
        }

        public override GrupoUsuarios Obtener(int idGrupo)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<GrupoUsuarios>();

            var objeto = repository.GetById(idGrupo);

            this.uow.Dispose();

            return objeto;
        }

        public IEnumerable<GrupoUsuarios> ObtenerGrupos(string descripcion)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<GrupoUsuarios>();

            var lista = repository.Query(x => x.gus_Descripcion.Contains(descripcion)).AsQueryable()
                .Include(x => x.Users).ToList();

            this.uow.Dispose();

            return lista;
        }
    }
}