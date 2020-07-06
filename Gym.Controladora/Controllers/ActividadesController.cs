namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class ActividadesController : IController<Actividades>
    {
        private readonly GestionarActividades GestionarActividades;
        private readonly OperacionesActividades OperacionesActividades;

        public ActividadesController()
        {
            this.GestionarActividades = new GestionarActividades();
            this.OperacionesActividades = new OperacionesActividades();
        }

        public void Eliminar(int idEntity) => this.OperacionesActividades.Eliminar(idEntity);

        public void Guardar(Actividades objeto, bool esModificacion)
        {
            if (esModificacion)
                this.OperacionesActividades.Modificar(objeto);
            else
                this.OperacionesActividades.Alta(objeto);
        } 

        public ICollection<Actividades> Listar() => this.GestionarActividades.Listar();

        public Actividades Obtener(int idEntity) => this.GestionarActividades.Obtener(idEntity);
    }
}