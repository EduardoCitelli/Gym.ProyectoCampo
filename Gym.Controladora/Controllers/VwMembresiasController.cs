namespace Gym.Controladora.Controllers
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class VwMembresiasController
    {
        private readonly GestionarVwMembresias gestionar;

        public VwMembresiasController()
        {
            this.gestionar = new GestionarVwMembresias();
        }

        public IEnumerable<VwMembresias> ObtenerMembresiasVendidas() => this.gestionar.Listar();
    }
}