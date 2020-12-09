namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class VwLogsController
    {
        private readonly GestionarVwLogs gestionar;

        public VwLogsController()
        {
            this.gestionar = new GestionarVwLogs();
        }

        public IEnumerable<vwLog> ListarLogs() => this.gestionar.Listar();
    }
}