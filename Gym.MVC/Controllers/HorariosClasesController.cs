namespace Gym.MVC.Controllers
{
    using Gym.Controladora;
    using Gym.MVC.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class HorariosClasesController : Controller
    {
        private readonly VwHorariosAltaController controladora;

        public HorariosClasesController()
        {
            this.controladora = new VwHorariosAltaController();            
        }

        public ActionResult Index()
        {
            var salones = this.controladora.GetListaSalones()
                                           .OrderBy(x => x.sal_Codigo)
                                           .Select(x => new SelectListItem() { Text = x.sal_Descripcion, Value = x.sal_Codigo.ToString() })
                                           .ToList();

            var model = new HorariosClasesModel(new List<Domain.VwHorariosAlta>(), salones)
            {
                filtrado = false
            };

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Index(HorariosClasesModel post)
        {
            var lista = this.controladora.ListarHorariosSemanaPorSalon(post.SalonSeleccionado);

            var salones = this.controladora.GetListaSalones().Select(x => new SelectListItem() { Text = x.sal_Descripcion, Value = x.sal_Codigo.ToString() }).ToList();

            var model = new HorariosClasesModel(lista, salones)
            {
                filtrado = true
            };

            return this.View(model);
        }
    }
}