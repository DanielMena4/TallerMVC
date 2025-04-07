using Microsoft.CodeAnalysis.CSharp.Syntax;
using TallerMVC.Models;

namespace TallerMVC.Repositories
{
    public class EquipoRepository
    {
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
            equipos.Add(ldu);
            return equipos;
        }
    }
}
