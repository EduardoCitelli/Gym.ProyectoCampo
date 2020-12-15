namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class VwFormasPago
    {
        [Key]
        public long Id { get; set; }

        public string FormaPago { get; set; }

        public int Cantidad { get; set; }

        public decimal ValorTotal { get; set; }
    }
}