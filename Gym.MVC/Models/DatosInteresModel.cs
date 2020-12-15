namespace Gym.MVC.Models
{
    using System.Collections.Generic;
    
    public class DatosInteresModel
    {
        public DatosInteresModel()
        {
            this.MembresiasActivas = new List<MembresiasActivasModel>();
            this.IngresosPorMembresias = new List<IngresoPorMembresiaModel>();
            this.AlumnosPorClases = new List<AlumnosPorClaseModel>();
            this.FormasPago = new List<FormaPagoModel>();
        }

        public IEnumerable<MembresiasActivasModel> MembresiasActivas { get; set; }

        public IEnumerable<IngresoPorMembresiaModel> IngresosPorMembresias { get; set; }

        public IEnumerable<AlumnosPorClaseModel> AlumnosPorClases { get; set; }

        public IEnumerable<FormaPagoModel> FormasPago { get; set; }
    }
}