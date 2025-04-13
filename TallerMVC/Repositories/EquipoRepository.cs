using Microsoft.CodeAnalysis.CSharp.Syntax;
using TallerMVC.Models;

namespace TallerMVC.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> equipos;
        public EquipoRepository()
        {
            equipos = DevuelveListdoEquipos();
        }
        public IEnumerable<Equipo> DevuelveListdoEquipos()
        {

            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
            };
            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2,
            };
            equipos.Add(ldu);
            equipos.Add(barcelona);
            return equipos;
        }
        public Equipo DevuelveEquipoPorId(int Id)
        {
            Equipo equipo = equipos.First(item => item.Id == Id);
            return equipo;
        }
        public bool ActualizarEquipo(int Id, Equipo equipo)
        {
            Equipo equipo1 = equipos.First(item => item.Id == Id);
            equipo1.Nombre = equipo.Nombre;
            equipo1.PartidosJugados = equipo.PartidosJugados;
            equipo1.PartidosGanados = equipo.PartidosGanados;
            equipo1.PartidosEmpatados = equipo.PartidosEmpatados;   
            equipo1.PartidosPerdidos = equipo.PartidosPerdidos;
            equipo1.Puntos = (equipo.PartidosGanados * 3) + (equipo.PartidosEmpatados); 
            return true;
        }
    }
}
