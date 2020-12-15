namespace Gym.MVC.Models
{
    using Gym.Domain;

    public class IngresoPorMembresiaModel
    {
        public IngresoPorMembresiaModel(VwIngresosPorMembresias ingreso)
        {
            this.Codigo = ingreso.Codigo;
            this.Membresia = ingreso.Membresia;
            this.Tipo = ingreso.Tipo;
            this.Ingresos = ingreso.Ingresos;
        }

        public int Codigo { get; set; }

        public string Membresia { get; set; }

        public string Tipo { get; set; }

        public decimal Ingresos { get; set; }
    }
}