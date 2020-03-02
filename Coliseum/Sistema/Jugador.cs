using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Dinero { get; set; }

        public Jugador()
        {
            Dinero = 0;
            Console.WriteLine("Ingresa el nombre del nuevo Jugador");
            Nombre = Console.ReadLine();
        }

    }
}
