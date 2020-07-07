namespace Gym.CasosDeUso
{
    using Gym.Datos;
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;
    using Common;

    public partial class GestionarUsuarios : Gestionable<Users>
    {
        public override ICollection<Users> Listar()
        {
            this.uow = new UnitOfWork();

            var repositorio = this.uow.GetRepository<Users>();

            var lista = repositorio.GetAll().AsQueryable().Include(x => x.Grupo).ToList();

            this.uow.Dispose();

            return lista;
        }

        public override Users Obtener(int idUsuario)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Users>();

            var usuario = repository.GetById(idUsuario);

            this.uow.Dispose();

            return usuario;
        }

        public Users Obtener(string usuario, string pass)
        {
            this.uow = new UnitOfWork();

            var passEncriptado = Encriptador.GetSha256(pass);

            var repository = this.uow.GetRepository<Users>();

            var user = repository.Query(x => x.usu_LoginName == usuario && x.usu_Password == passEncriptado)
                .AsQueryable().Include(x => x.Grupo).FirstOrDefault();

            this.uow.Dispose();

            return user;
        }

        public ICollection<Users> Listar(string nombre)
        {
            this.uow = new UnitOfWork();

            var repository = this.uow.GetRepository<Users>();

            var usuarios = repository.Query(x => x.usu_Nombre.Contains(nombre))
                .AsQueryable().Include(x => x.Grupo).ToList();

            this.uow.Dispose();

            return usuarios;
        }
    }
}