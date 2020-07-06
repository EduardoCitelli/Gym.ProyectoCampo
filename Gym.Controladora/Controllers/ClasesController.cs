namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class ClasesController : IController<Clases>
    {
        private readonly GestionarClases gestionarClases;
        private readonly OperacionesClases operacionesClases;

        private readonly OperacionesClases_Socios operacionesClases_Socios;

        public ClasesController()
        {
            this.gestionarClases = new GestionarClases();
            this.operacionesClases = new OperacionesClases();
            this.operacionesClases_Socios = new OperacionesClases_Socios();
        }

        public void Eliminar(int idEntity) => this.operacionesClases.Eliminar(idEntity);

        public void Guardar(Clases objeto, bool esModificacion)
        {
            if (esModificacion) this.operacionesClases.Modificar(objeto);

            else this.operacionesClases.Alta(objeto);
        }

        public ICollection<Clases> Listar() => this.gestionarClases.Listar();

        public Clases Obtener(int idEntity) => this.gestionarClases.Obtener(idEntity);

        public Clases ObtenerCompleto(int idEntity) => this.gestionarClases.ObtenerCompleto(idEntity);

        public ICollection<Clases> ListarCompleto() => this.gestionarClases.ListarCompleto();

        public void DarDeBajaClase(Clases clase)
        {
            this.operacionesClases_Socios.EliminarPorClase(clase.cls_Id);

            clase.cls_Estado = "P";

            this.operacionesClases.Modificar(clase);
        }
    }
}