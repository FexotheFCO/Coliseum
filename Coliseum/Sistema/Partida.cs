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

        public Partida()
        {
            Jugador = new Jugador();
            Escuela = new EscuelaDeGladiadores();
        }

        public void CorrerMenu()
        {
            Escuela.Menu();
        }
    }
}
