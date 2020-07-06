namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations;

    public partial class Salones
    {
        [Key]
        public int sal_Codigo { get; set; }

        public string sal_Descripcion { get; set; }

        public decimal sal_Tamanio { get; set; }

        public int sal_Capacidad { get; set; }

        public int sal_Nro { get; set; }

        public int sal_Piso { get; set; }
    }
}