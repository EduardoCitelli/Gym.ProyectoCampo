namespace Gym.MVC.Models
{
    using Gym.Domain;
    using System;
    
    public class VentaMembresiaModel
    {
        public VentaMembresiaModel(VwMembresias membresias)
        {
            this.Id = membresias.Vw_Id;

            this.FechaPago = membresias.FechaPago;

            this.CodigoSocio = membresias.CodigoSocio;

            this.Socio = membresias.Socio;

            this.Membresia = membresias.Membresia;

            this.TipoMembresias = membresias.TipoMembresia;

            this.Actividad = membresias.Actividad;

            this.PrecioFacturado = membresias.PrecioFacturado;

            this.FormaPago = membresias.FormaPago;
        }

        public int Id { get; set; }

        public DateTime FechaPago { get; set; }

        public int CodigoSocio { get; set; }

        public string Socio { get; set; }

        public string Membresia { get; set; }

        public string TipoMembresias { get; set; }

        public string Actividad { get; set; }

        public decimal PrecioFacturado { get; set; }

        public string FormaPago { get; set; }
    }
}