namespace Gym.MVC.Controllers
{
    using Gym.Controladora;
    using Gym.MVC.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HorariosClasesController : Controller
    {
        private readonly VwHorariosAltaController controladora = new VwHorariosAltaController();
        
        public ActionResult Index()
        {
            var lista = this.controladora.ListarHorariosSemana();

            var model = new HorariosClasesModel(lista);

            return this.View(model);
        }
    }
}