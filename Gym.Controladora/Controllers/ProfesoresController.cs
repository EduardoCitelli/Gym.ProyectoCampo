namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class ProfesoresController : IController<Profesores>
    {
        private readonly GestionarProfesores gestionarProfesores;
        private readonly OperacionesProfesores operacionesProfesores;

        public ProfesoresController()
        {
            this.gestionarProfesores = new GestionarProfesores();
            this.operacionesProfesores = new OperacionesProfesores();
        }

        public void Eliminar(int idEntity) => this.operacionesProfesores.Eliminar(idEntity);

        public void Guardar(Profesores objeto, bool esModificacion)
        {
            if (esModificacion) this.operacionesProfesores.Modificar(objeto);

            else this.operacionesProfesores.Alta(objeto);
        }

        public ICollection<Profesores> Listar() => this.gestionarProfesores.Listar();

        public Profesores Obtener(int idEntity) => this.gestionarProfesores.Obtener(idEntity);
    }
}