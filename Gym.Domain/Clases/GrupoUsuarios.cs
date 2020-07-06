namespace Gym.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class GrupoUsuarios
    {
        [Key]
        public int gus_Id { get; set; }

        public string gus_Descripcion { get; set; }

        public virtual ICollection<Users> Users { get; set; }

        public override string ToString() => this.gus_Descripcion;
    }
}
