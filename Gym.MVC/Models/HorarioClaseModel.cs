namespace Gym.MVC.Models
{
    using Gym.Domain;
    using System;

    public class HorarioClaseModel
    {
        public HorarioClaseModel(VwHorariosAlta horario)
        {
            this.Actividad = horario.Actividad;
            this.Inicio = horario.Inicio;
            this.Final = horario.Final;
            this.Profesor = horario.Profesor;
            this.CodigoSalon = horario.CodigoSalon;
            this.Salon = horario.Salon;
        }

        public string Actividad { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Final { get; set; }

        public string Profesor { get; set; }

        public int CodigoSalon { get; set; }

        public string Salon { get; set; }
    }
}