namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Clases_Socios
    {
        [Key]
        public int css_Id { get; set; }

        public int css_soc_Codigo { get; set; }

        public int css_cls_Id { get; set; }
                
        [ForeignKey(nameof(css_soc_Codigo))]
        public virtual Socios Socio { get; set; }

        [ForeignKey(nameof(css_cls_Id))]
        public virtual Clases Clase { get; set; }
    }
}