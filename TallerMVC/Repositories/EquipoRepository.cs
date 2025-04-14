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
        public static List<Equipo> _equipos = new List<Equipo>(){

             new Equipo
            {
                Id = 1,
                Nombre = "Vinotinto",
                PartidosJugados = 8,
                PartidosGanados = 4,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                ImagenRuta = "~/res/Logos/Vinotinto.jpg",
            },
             new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 6,
                PartidosGanados = 5,
                PartidosEmpatados = 0,
                PartidosPerdidos = 1,
                ImagenRuta = "~/res/Logos/bsc.png",
            },
             new Equipo
            {
                Id = 3,
                Nombre = "U. Católica",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                ImagenRuta = "~/res/Logos/UCatolica.png",
            },
             new Equipo
            {
                Id = 4,
                Nombre = "IDV",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                ImagenRuta = "~/res/Logos/IDV.png",
            },
             new Equipo
            {
                Id = 5,
                Nombre = "Libertad FC",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                ImagenRuta = "~/res/Logos/LFC.png",
            },
             new Equipo
            {
                Id = 6,
                Nombre = "Liga de Quito",
                PartidosJugados = 6,
                PartidosGanados = 3,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
                ImagenRuta = "~/res/Logos/LDU.png",
            },
             new Equipo
            {
                Id = 7,
                Nombre = "Dep. Cuenca",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 4,
                ImagenRuta = "~/res/Logos/DepCuenca.png",
            },
             new Equipo
            {
                Id = 8,
                Nombre = "Orense",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 3,
                ImagenRuta = "~/res/Logos/Orense.png",
            },
             new Equipo
            {
                Id = 9,
                Nombre = "Mushuc Runa",
                PartidosJugados = 7,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                ImagenRuta = "~/res/Logos/MushucRuna.png",
            },
             new Equipo
            {
                Id = 10,
                Nombre = "Aucas",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
                ImagenRuta = "~/res/Logos/Aucas.png",
            },
             new Equipo
            {
                Id = 11,
                Nombre = "Macará",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
                ImagenRuta = "~/res/Logos/Macara.png",
            },
             new Equipo
            {
                Id = 12,
                Nombre = "Manta",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
                ImagenRuta = "~/res/Logos/manta.png",
            },
             new Equipo
            {
                Id = 13,
                Nombre = "Emelec",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 4,
                PartidosPerdidos = 3,
                ImagenRuta = "~/res/Logos/Emelec.png",
            },
             new Equipo
            {
                Id = 14,
                Nombre = "Tec. Universitario",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 4,
                PartidosPerdidos = 3,
                ImagenRuta = "~/res/Logos/TecUniversitario.png",
            },
             new Equipo
            {
                Id = 15,
                Nombre = "Delfin",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
                ImagenRuta = "~/res/Logos/Delfin.png",
            },
             new Equipo
            {
                Id = 16,
                Nombre = "El Nacional",
                PartidosJugados = 7,
                PartidosGanados = 1,
                PartidosEmpatados = 2,
                PartidosPerdidos = 4,
                ImagenRuta = "~/res/Logos/Nacional.png",
            }
        };
        public IEnumerable<Equipo> DevuelveListdoEquipos()
        {
            return _equipos;
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
