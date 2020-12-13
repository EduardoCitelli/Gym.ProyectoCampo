namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class VwMembresias
    {
        [Key]
        public int Vw_Id { get; set; }

        public DateTime FechaPago { get; set; }

        public int CodigoSocio { get; set; }

        public string Socio { get; set; }

        public string Membresia { get; set; }

        public string TipoMembresia { get; set; }

        public string Actividad { get; set; }

        public decimal PrecioFacturado { get; set; }

        public string FormaPago { get; set; }
    }
}