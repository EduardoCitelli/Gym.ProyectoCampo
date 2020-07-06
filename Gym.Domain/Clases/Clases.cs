namespace Gym.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Clases
    {
        [Key]
        public int cls_Id { get; set; }

        public string cls_Descripcion { get; set; }

        public DateTime cls_FechaInicio { get; set; }

        public DateTime cls_FechaFinal { get; set; }

        public string cls_Estado { get; set; }

        public int cls_pro_Titular { get; set; }

        public int? cls_pro_Auxiliar { get; set; }

        public int cls_act_Codigo { get; set; }

        public int cls_sal_Codigo { get; set; }

        [ForeignKey(nameof(cls_pro_Titular))]
        public virtual Profesores Titular { get; set; }

        [ForeignKey(nameof(cls_pro_Auxiliar))]
        public virtual Profesores Auxiliar { get; set; }

        [ForeignKey(nameof(cls_act_Codigo))]
        public virtual Actividades Actividad { get; set; }

        [ForeignKey(nameof(cls_sal_Codigo))]
        public virtual Salones Salon { get; set; }

        public virtual List<Clases_Socios> SociosInscriptos { get; set; }
    }
}