namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class VwFormasPagoController
    {
        private readonly GestionarVwFormasPago gestionar;

        public VwFormasPagoController()
        {
            this.gestionar = new GestionarVwFormasPago();
        }

        public IEnumerable<VwFormasPago> ObtenerFormasPago() => this.gestionar.Listar();
    }
}