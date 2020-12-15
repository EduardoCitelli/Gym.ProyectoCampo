namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class VwAlumnosPorClaseController
    {
        private readonly GestionarVwAlumnosPorClase gestionar;

        public VwAlumnosPorClaseController()
        {
            this.gestionar = new GestionarVwAlumnosPorClase();
        }

        public IEnumerable<VwAlumnosPorClase> ObtenerAlumnosPorClase() => this.gestionar.Listar();
    }
}