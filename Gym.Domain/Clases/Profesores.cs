namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Profesores
    {
        [Key]
        public int pro_Codigo { get; set; }

        public string pro_Nombre { get; set; }

        public string pro_Apellido { get; set; }

        public long pro_Telefono { get; set; }

        public DateTime pro_FechaNacimiento { get; set; }

        public decimal pro_Sueldo { get; set; }

        public string pro_Mail { get; set; }

        public int pro_Dni { get; set; }

        public string pro_Direccion { get; set; }
    }
}
