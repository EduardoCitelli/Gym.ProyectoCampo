namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class VwIngresosPorMembresiasController
    {
        private readonly GestionarVwIngresosPorMembresias gestionar;

        public VwIngresosPorMembresiasController()
        {
            this.gestionar = new GestionarVwIngresosPorMembresias();
        }

        public IEnumerable<VwIngresosPorMembresias> ObtenerIngresosPorMembresias() => this.gestionar.Listar();
    }
}