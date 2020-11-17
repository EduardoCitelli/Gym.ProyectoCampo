using Gym.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.MVC.Models
{
    public class HorariosClasesModel
    {
        public HorariosClasesModel(IEnumerable<VwHorariosAlta> horarios)
        {
            this.Horarios = horarios.Select(x => new HorarioClaseModel(x)).ToList();
        }

        public IEnumerable<HorarioClaseModel> Horarios { get; set; }
    }
}