namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    
    public class VwHorariosAltaController
    {
        private readonly GestionarVwHorariosAlta gestionar;

        public VwHorariosAltaController()
        {
            this.gestionar = new GestionarVwHorariosAlta();
        }

        public IEnumerable<VwHorariosAlta> ListarHorariosSemana() => this.gestionar.ListarClasesSemanales();
    }
}