using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    class Jugador
    {
        string Nombre { get; set; }
        int Dinero { get; set; }
        EscuelaDeGladiadores Escuela { get; set; }

        public Jugador()
        {
            Dinero = 0;
            Console.WriteLine("Ingresa el nombre del nuevo Jugador");
            Nombre = Console.ReadLine();
            Escuela = new EscuelaDeGladiadores();
            Escuela.Menu();
        }

    }
}
