using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    public class Partida
    {
        public string Nombre { get; set; } 
        public Jugador Jugador { get; set; }

        public EscuelaDeGladiadores Escuela { get; set; }

        [JsonConstructor]
        public Partida()
        {

        }
        public Partida(String nombre)
        {
            this.Nombre = nombre;
            Console.WriteLine("Escriba el nombre del nuevo Jugador");
            string nombreJugador = Console.ReadLine();
            Jugador = new Jugador(nombreJugador);
            Console.WriteLine("Escriba el nombre de la nueva Escuela");
            string nombreEscuela = Console.ReadLine();
            Escuela = new EscuelaDeGladiadores(nombreEscuela);
        }

        public void CorrerMenu()
        {
            Escuela.Menu();
        }
    }
}
