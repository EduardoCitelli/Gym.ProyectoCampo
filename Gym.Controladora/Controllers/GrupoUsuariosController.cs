namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class GrupoUsuariosController
    {
        private GestionarGrupoUsuarios gestionar;
        private OperacionesGrupoUsuario operaciones;

        public GrupoUsuariosController()
        {
            this.gestionar = new GestionarGrupoUsuarios();
            this.operaciones = new OperacionesGrupoUsuario();
        }

        public ICollection<GrupoUsuarios> Listar() => this.gestionar.Listar();

        public void GuardarGrupo(GrupoUsuarios grupo, bool esModificacion)
        {
            if (esModificacion)
                this.operaciones.Modificar(grupo);
            else
                this.operaciones.Alta(grupo);
        }

        public void EliminarGrupo(int idGrupo) => this.operaciones.Eliminar(idGrupo);

        public GrupoUsuarios ObtenerGrupo(int idGrupo) => this.gestionar.Obtener(idGrupo);

        public IEnumerable<GrupoUsuarios> ObtenerGrupos(string descripcion) => this.gestionar.ObtenerGrupos(descripcion);
    }
}
