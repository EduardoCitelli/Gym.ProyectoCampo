namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class VwIngresosPorMembresias
    {
        [Key]
        public int Codigo { get; set; }

        public string Membresia { get; set; }

        public string Tipo { get; set; }

        public decimal Ingresos { get; set; }
    }
}