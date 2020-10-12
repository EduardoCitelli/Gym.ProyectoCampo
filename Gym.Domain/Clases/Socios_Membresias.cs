namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Socios_Membresias
    {
        [Key]
        public int sms_Id { get; set; }

        public int sms_soc_Codigo { get; set; }

        public int sms_mem_Id { get; set; }

        public decimal sms_Precio { get; set; }

        public DateTime sms_FechaAlta { get; set; }

        public string sms_FormaPago { get; set; }

        public int? sms_act_Codigo { get; set; }

        [ForeignKey(nameof(sms_soc_Codigo))]
        public virtual Socios Socio { get; set; }

        [ForeignKey(nameof(sms_mem_Id))]
        public virtual Membresias Membresia { get; set; }

        [ForeignKey(nameof(sms_act_Codigo))]
        public virtual Actividades ActividadElegida { get; set; }
    }
}