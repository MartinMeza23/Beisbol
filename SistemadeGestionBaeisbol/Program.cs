using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeGestionBaeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo LosAngeles = new Equipo("LosAngeles", "1");
            Equipo NewYork = new Equipo("NewYork", "2");




            equipos.Add(LosAngeles);
            Jugador juan = new Jugador("juan", "21");
            Jugador lalo = new Jugador("lalo", "76");
            Jugador pedro = new Jugador("pedro", "89");
            Jugador ernesto = new Jugador("ernesto", "41");
            Jugador jesus = new Jugador("jesus", "98");
            Jugador gomez = new Jugador("gomez", "31");
            Jugador rodrigo = new Jugador("rodrigo", "26");
            Jugador alex = new Jugador("alex", "59");
            Jugador leo = new Jugador("leo", "65");

            equipos.Add(NewYork);
            Jugador martin = new Jugador("martin", "71");
            Jugador alexis = new Jugador("alexis", "96");
            Jugador carlos = new Jugador("carlos", "59");
            Jugador bryan = new Jugador("bryan", "61");
            Jugador jose = new Jugador("jose", "45");
            Jugador juanc = new Jugador("juanc", "64");
            Jugador bartolo = new Jugador("bartolo", "55");
            Jugador frank = new Jugador("frank", "2");
            Jugador pancho = new Jugador("pancho", "7");





            LosAngeles.Jugadores.Add(juan);
            LosAngeles.Jugadores.Add(lalo);
            LosAngeles.Jugadores.Add(pedro);
            LosAngeles.Jugadores.Add(ernesto);
            LosAngeles.Jugadores.Add(jesus);
            LosAngeles.Jugadores.Add(gomez);
            LosAngeles.Jugadores.Add(rodrigo);
            LosAngeles.Jugadores.Add(alex);
            LosAngeles.Jugadores.Add(leo);

            NewYork.Jugadores.Add(martin);
            NewYork.Jugadores.Add(alexis);
            NewYork.Jugadores.Add(carlos);
            NewYork.Jugadores.Add(bryan);
            NewYork.Jugadores.Add(jose);
            NewYork.Jugadores.Add(juanc);
            NewYork.Jugadores.Add(bartolo);
            NewYork.Jugadores.Add(frank);
            NewYork.Jugadores.Add(pancho);


            foreach (Equipo equipo in equipos)
            {

                Console.WriteLine("Equipo: " + equipo.Codigo);
                Console.WriteLine("EquipoN: " + equipo.EquipoN);
                Console.WriteLine("Lista de Jugadores:");

                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("*" + jugador.Nombre);
                }

            }

            Console.Read();
        }
    }
}
