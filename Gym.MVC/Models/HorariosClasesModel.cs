using Gym.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym.MVC.Models
{
    public class HorariosClasesModel
    {
        public HorariosClasesModel()
        {
            this.Horarios = new List<HorarioClaseModel>();
            this.Salones = new List<SelectListItem>();
        }

        public HorariosClasesModel(IEnumerable<VwHorariosAlta> horarios, List<SelectListItem> salones)
        {
            this.Horarios = horarios.Select(x => new HorarioClaseModel(x)).ToList();
            this.Salones = salones;
        }

        public IEnumerable<HorarioClaseModel> Horarios { get; set; }

        public List<SelectListItem> Salones { get; set; }

        public int SalonSeleccionado { get; set; }

        public bool filtrado { get; set; }
    }
}