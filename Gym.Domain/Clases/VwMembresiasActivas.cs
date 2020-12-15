namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class VwMembresiasActivas
    {
        [Key]
        public int Codigo { get; set; }

        public string Membresia { get; set; }

        public int Cantidad { get; set; }
    }
}