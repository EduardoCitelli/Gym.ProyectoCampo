namespace Gym.Domain
{    
    public partial class Socios_Membresias
    {
        public string NombreSocio => this.Socio.soc_Nombre;

        public string DescripcionMembresia => this.Membresia.mem_Descripcion;

        public string Periodo => $"{this.sms_FechaAlta.ToShortDateString()} - {this.sms_FechaAlta.AddMonths(this.Membresia.Tipo.tmm_CantidadMeses).ToShortDateString()}";
    }
}