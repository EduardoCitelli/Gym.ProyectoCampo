namespace Gym.MVC.Controllers
{
    using Gym.Controladora.Controllers;
    using Gym.MVC.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class VentasMembresiasController : Controller
    {
        private readonly VwMembresiasController controller;

        public VentasMembresiasController()
        {
            this.controller = new VwMembresiasController();            
        }

        public ActionResult Index()
        {
            var registros = this.controller.ObtenerMembresiasVendidas();

            var model = registros.Select(x => new VentaMembresiaModel(x)).ToList();

            return this.View(model);
        }
    }
}