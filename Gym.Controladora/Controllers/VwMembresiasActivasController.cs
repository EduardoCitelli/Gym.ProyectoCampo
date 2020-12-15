namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class VwMembresiasActivasController
    {
        private readonly GestionarVwMembresiasActivas gestionar;
        public VwMembresiasActivasController()
        {
            this.gestionar = new GestionarVwMembresiasActivas();
        }

        public IEnumerable<VwMembresiasActivas> ObtenerMembresiasActivas() => this.gestionar.Listar();
    }
}