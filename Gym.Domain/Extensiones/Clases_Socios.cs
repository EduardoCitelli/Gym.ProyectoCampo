namespace Gym.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class Clases_Socios
    {
        [NotMapped]
        public string NombreSocios => this.Socio?.soc_Nombre;

        [NotMapped]
        public string NombreClase => this.Clase?.cls_Descripcion;

        [NotMapped]
        public string FechaClase => $"{this.Clase?.cls_FechaInicio.ToShortDateString()} {this.Clase?.cls_FechaInicio.ToShortTimeString()}hs - {this.Clase?.cls_FechaFinal.ToShortTimeString()}hs";

        [NotMapped]
        public string NombreProfesorTitular => $"{this.Clase?.Titular.pro_Nombre} {this.Clase?.Titular.pro_Apellido}";

        [NotMapped]
        public string Actividad => this.Clase?.Actividad.act_Descripcion;

        [NotMapped]
        public string Salon => this.Clase?.Salon.sal_Descripcion;
    }
}