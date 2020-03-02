using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    class Partida
    {
        List<string> datos { get; set; }
        string Nombre { get; set; } 
        Jugador Jugador { get; set; }

        public Partida()
        {
            Jugador = new Jugador(); 
        }

    }
}
