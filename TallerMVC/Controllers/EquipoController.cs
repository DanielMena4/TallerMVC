using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMVC.Models;
using TallerMVC.Repositories;

namespace TallerMVC.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult View()
        {
            return View();
        }
        public ActionResult List()
        {
            EquipoRepository equipoRepository = new EquipoRepository();
            var equipos = equipoRepository.DevuelveListdoEquipos();

            equipos = equipos.OrderByDescending(item => item.PartidosGanados);
            
            return View(equipos);
        }

    }
}
