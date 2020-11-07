namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ComprobanteEmitido
    {
        [Key]
        public int cem_Id { get; set; }

        public DateTime cem_FechaEmision { get; set; }

        public int cem_NroTransaccion { get; set; }

        public decimal cem_Precio { get; set; }

        public string cem_FormaPago { get; set; }

        public DateTime cem_FechaVencimiento { get; set; }

        public int? cem_CantidadClases { get; set; }

        public string cem_Actividad { get; set; }

        public int cem_soc_Codigo { get; set; }

        [ForeignKey(nameof(cem_soc_Codigo))]
        public virtual Socios Socio { get; set; }
    }
}