namespace Gym.CasosDeUso
{
    using Common;
    using Gym.Datos;
    using Gym.Domain;
    using System;

    public partial class OperacionesUsuarios : Operable<Users>
    {
        public override void Alta(Users usuario)
        {
            try
            {
                this.uow = new UnitOfWork();

                var passEncriptado = Encriptador.GetSha256(usuario.usu_Password);

                usuario.usu_Password = passEncriptado;

                var repository = this.uow.GetRepository<Users>();

                repository.Add(usuario);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el usuario", ex);
            }
        }

        public override void Eliminar(int idUsuario)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Users>();

            var objeto = repository.GetById(idUsuario);

            try
            {
                repository.Remove(objeto);

                this.uow.Save();
                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar el usuario", ex);
            }
        }

        public override void Modificar(Users usuario)
        {
            try
            {
                this.uow = new UnitOfWork();

                var repository = this.uow.GetRepository<Users>();

                var passEncriptado = Encriptador.GetSha256(usuario.usu_Password);

                usuario.usu_Password = passEncriptado;

                repository.Edit(usuario);

                this.uow.Save();

                this.uow.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar el usuario", ex);
            }            
        }
    }
}
