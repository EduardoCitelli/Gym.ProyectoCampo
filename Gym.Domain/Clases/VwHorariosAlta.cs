namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class VwHorariosAlta
    {
        [Key]
        public int Id { get; set; }

        public string Actividad { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Final { get; set; }

        public string Profesor { get; set; }

        public int CodigoSalon { get; set; }

        public string Salon { get; set; }
    }
}