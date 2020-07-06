namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System;
    using System.Linq;

    public partial class OperacionesGrupoUsuario : Operable<GrupoUsuarios>
    {
        private UnitOfWork uow;

        public override void Alta(GrupoUsuarios grupo)
        {
            try
            {
                this.uow = new UnitOfWork();

                var repository = this.uow.GetRepository<GrupoUsuarios>();

                repository.Add(grupo);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el Grupo", ex);
            }
        }

        public override void Eliminar(int idGrupo)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<GrupoUsuarios>();

            var objeto = repository.GetById(idGrupo);

            if (objeto.Users.Any())
                throw new Exception("El Grupo tiene Usuarios asignados y no puede ser Eliminado");

            try
            {
                repository.Remove(objeto);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar el Grupo", ex);
            }
        }

        public override void Modificar(GrupoUsuarios grupo)
        {
            try
            {
                this.uow = new UnitOfWork();

                var repository = this.uow.GetRepository<GrupoUsuarios>();

                repository.Edit(grupo);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar el Grupo", ex);
            }
        }
    }
}