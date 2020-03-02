using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    public class Gladiador
    {
        public int ID { get; set; }
        public int Vida { get; set; }
        public int Fuerza { get; set; }
        public int Precio { get; set; }

        List<Armaduras> Armadura { get; set; }

        public string  imprimirDatos()
        {
            string resultado = (@".--------------." + "\n" +
                              @"|    /~~\      |" + "\n" +
                              @"| W < %% >     |" + "\n" +
                              @"|  \ \--/      |" + "\n" +
                              @"|    \II   W   |" + "\n" +
                              @"|     <>\__|   |" + "\n" +
                              @"|     <>       |" + "\n" +
                              @"|    /  \      |" + "\n" +
                              @"|   /    \     |" + "\n" +
                              @"`--------------'" + "\n" +
                              "Vida : "+Vida+ "\nFuerza : " + Fuerza + "\nPrecio : " + Precio);
            return resultado;
        }
    }
}
