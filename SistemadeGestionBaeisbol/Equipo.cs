using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeGestionBaeisbol
{
    class Equipo
    {
        public string EquipoN { get; set; }
        public string Codigo { get; set; }

        public List<Jugador> Jugadores { get; set; }


        public Equipo(string equipon, string codigo)
        {
            EquipoN = equipon;
            Codigo = codigo;

            Jugadores = new List<Jugador>();

        }
    }
}
