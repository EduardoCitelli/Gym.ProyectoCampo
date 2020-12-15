namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;

    public class UsersController
    {
        private GestionarUsuarios gestionarUsuarios;
        
        private OperacionesUsuarios operacionesUsuarios;        

        public UsersController()
        {
            this.gestionarUsuarios = new GestionarUsuarios();
            this.operacionesUsuarios = new OperacionesUsuarios();
        }

        public ICollection<Users> ListarUsuarios() => this.gestionarUsuarios.Listar();

        public void Guardar(Users usuario, bool esModificacion)
        {
            if (esModificacion)
                this.operacionesUsuarios.Modificar(usuario);
            else
                this.operacionesUsuarios.Alta(usuario);
        }

        public void Eliminar(int idUsuario) => this.operacionesUsuarios.Eliminar(idUsuario);

        public Users Obtener(int idUsuario) => this.gestionarUsuarios.Obtener(idUsuario);

        public Users ObtenerUsuario(string usuario, string pass) => this.gestionarUsuarios.Obtener(usuario, pass);

        public ICollection<Users> ObtenerUsuarios(string nombre) => this.gestionarUsuarios.Listar(nombre);

        public Users ObtenerPorMail(string mail) => this.gestionarUsuarios.ObtenerPorMail(mail);
    }
}