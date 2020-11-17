namespace Gym.Domain
{
    using System;
    
    public class VwHorariosAlta
    {
        public int Id { get; set; }

        public string Actividad { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Final { get; set; }

        public string Profesor { get; set; }

        public int CodigoSalon { get; set; }

        public string Salon { get; set; }
    }
}