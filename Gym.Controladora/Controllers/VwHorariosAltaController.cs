namespace Gym.Controladora
{
    using Gym.CasosDeUso;
    using Gym.Domain;
    using System.Collections.Generic;
    using System.Linq;

    public class VwHorariosAltaController
    {
        private readonly GestionarVwHorariosAlta gestionar;
        private readonly GestionarSalones gestionarSalones;

        public VwHorariosAltaController()
        {
            this.gestionar = new GestionarVwHorariosAlta();
            this.gestionarSalones = new GestionarSalones();
        }

        public IEnumerable<VwHorariosAlta> ListarHorariosSemana() => this.gestionar.ListarClasesSemanales();

        public IEnumerable<VwHorariosAlta> ListarHorariosSemanaPorSalon(int codigoSalon) => this.gestionar.ListarClasesSemanalesPorSalon(codigoSalon);

        public List<Salones> GetListaSalones() => this.gestionarSalones.Listar().ToList();
    }
}