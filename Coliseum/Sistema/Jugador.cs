using Newtonsoft.Json;
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

        [JsonConstructor]
        public Jugador()
        {

        }
        public Jugador(string nombre)
        {
            Dinero = 0;
            this.Nombre = nombre;
        }

    }
}
