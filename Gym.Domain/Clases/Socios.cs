namespace Gym.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Socios
    {
        [Key]
        public int soc_Codigo { get; set; }

        public string soc_Nombre { get; set; }

        public string soc_Apellido { get; set; }

        public string soc_Mail { get; set; }

        public DateTime soc_FechaNacimiento { get; set; }

        public bool soc_Activo { get; set; }

        public long soc_Telefono { get; set; }

        public int soc_Dni { get; set; }

        public string soc_Domicilio { get; set; }

        public string soc_Sexo { get; set; }

        public int? soc_mem_Id { get; set; }

        public DateTime? soc_FechaMembresia { get; set; }

        public int? soc_CantidadClasesDisponibles { get; set; }

        [ForeignKey(nameof(soc_mem_Id))]
        public virtual Membresias Membresia { get; set; }

        public virtual List<Clases_Socios> ClasesInscriptas { get; set; }
    }
}
