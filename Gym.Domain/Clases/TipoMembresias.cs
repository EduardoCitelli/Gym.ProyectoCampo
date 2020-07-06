namespace Gym.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TipoMembresias
    {
        [Key]
        public int tmm_Id { get; set; }

        public string tmm_Descripcion { get; set; }

        public bool tmm_EsMensual { get; set; }

        public int tmm_CantidadMeses { get; set; }

        public int? tmm_CantidadClases { get; set; }

        public virtual ICollection<Membresias> Membresias { get; set; }

        public override string ToString() => this.tmm_Descripcion;
    }
}
