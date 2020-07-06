namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class TipoMembresiasController
    {
        private readonly GestionarTipoMembresias gestionarTipoMembresias;

        private readonly OperacionesTipoMembresias operacionesTipoMembresias;

        public TipoMembresiasController()
        {
            this.gestionarTipoMembresias = new GestionarTipoMembresias();
            this.operacionesTipoMembresias = new OperacionesTipoMembresias();
        }

        public ICollection<TipoMembresias> Listar() => this.gestionarTipoMembresias.Listar();

        public void GuardarTipoMembresia(TipoMembresias tipoMembresias, bool esModificacion)
        {
            if (esModificacion)
                this.operacionesTipoMembresias.Modificar(tipoMembresias);
            else
                this.operacionesTipoMembresias.Alta(tipoMembresias);
        }

        public void EliminarTipoMembresia(int idTipoMembresia) 
            => this.operacionesTipoMembresias.Eliminar(idTipoMembresia);

        public TipoMembresias ObtenerTipoMembresia(int idTipoMembresia) => this.gestionarTipoMembresias.Obtener(idTipoMembresia);

        public IEnumerable<TipoMembresias> ObtenerTipoMembresiasPorDescripcion(string descripcion) 
            => this.gestionarTipoMembresias.ObtenerTiposMembresiasPorDescripcion(descripcion);
    }
}