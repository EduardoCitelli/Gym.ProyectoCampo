namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class MembresiasController : IController<Membresias>
    {
        private readonly GestionarMembresias GestionarMembresias;
        private readonly OperacionesMembresias OperacionesMembresias;

        public MembresiasController()
        {
            this.OperacionesMembresias = new OperacionesMembresias();
            this.GestionarMembresias = new GestionarMembresias();
        }

        public ICollection<Membresias> Listar() => this.GestionarMembresias.Listar();

        public Membresias Obtener(int idMembresia) => this.GestionarMembresias.Obtener(idMembresia);

        public ICollection<Membresias> ObtenerPorDescripcion(string descripcion)
            => this.GestionarMembresias.ObtenerPorDescripcion(descripcion);

        public void Guardar(Membresias membresia, bool esModificacion)
        {
            if (esModificacion) this.OperacionesMembresias.Modificar(membresia);

            else this.OperacionesMembresias.Alta(membresia);
        }

        public void Eliminar(int idMembresia) => this.OperacionesMembresias.Eliminar(idMembresia);
    }
}
