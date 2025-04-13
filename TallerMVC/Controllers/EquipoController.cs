using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using TallerMVC.Models;
using TallerMVC.Repositories;

namespace TallerMVC.Controllers
{
    public class EquipoController : Controller
    {
        EquipoRepository _repository;
        public ActionResult View()
        {
            return View();
        }
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public ActionResult List()
        {
            var equipos = _repository.DevuelveListdoEquipos();
            foreach (var item in equipos)
            {
                item.Puntos = (item.PartidosGanados * 3) + (item.PartidosEmpatados);
            }
            equipos = equipos.OrderByDescending(item => item.PartidosGanados);
            
            return View(equipos);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch 
            {
                return View();
            }
        }
        public ActionResult Edit(int Id)
        {
            Equipo equipo = _repository.DevuelveEquipoPorId(Id);
            return View(equipo);
        }
    }
}
