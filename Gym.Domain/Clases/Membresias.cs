namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Membresias
    {
        [Key]
        public int mem_Codigo { get; set; }

        public string mem_Descripcion { get; set; }

        public int mem_tmm_Id { get; set; }

        public bool mem_EsPremium { get; set; }

        public decimal mem_Precio { get; set; }

        [ForeignKey(nameof(mem_tmm_Id))]
        public virtual TipoMembresias Tipo { get; set; }
    }
}