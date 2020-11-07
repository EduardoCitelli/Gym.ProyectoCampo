namespace Gym.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Socios
    {
        public Socios()
        {
            this.ClasesInscriptas = new List<Clases_Socios>();
            this.HistoricoMembresias = new List<Socios_Membresias>();
        }

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

        public int? soc_mem_Codigo { get; set; }

        public int? soc_act_Codigo { get; set; }

        public DateTime? soc_FechaVtoMembresia { get; set; }

        public int? soc_CantidadClasesDisponibles { get; set; }

        [ForeignKey(nameof(soc_mem_Codigo))]
        public virtual Membresias Membresia { get; set; }

        [ForeignKey(nameof(soc_act_Codigo))]
        public virtual Actividades ActividadInscripta { get; set; }

        public virtual List<Clases_Socios> ClasesInscriptas { get; set; }

        public virtual List<Socios_Membresias> HistoricoMembresias { get; set; }
    }
}
