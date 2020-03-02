using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Torneos
{
    public class Encuentro
    {
        public Gladiador GladiadorJugador { get; set; }
        public Gladiador GladiadorEnemigo { get; set; }
        bool salir = false;
        public Dictionary<string, string> decisiones = new Dictionary<string, string>();

        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(MostrarStatus());
                Console.WriteLine("1.Pegar\n2.Defender");
                int decision = 0;
                try
                {
                    decision = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor escriba un numero");
                    Console.ReadKey();
                }
                Decision(decision);
                DecisionIa();
                CorrerTurno();
                Verificacion();
            } while (!salir);
        }

        public void Decision(int decision)
        {
            if(decision == 1)
            {
                decisiones.Add("PJ1", "ATACAR");
            }else
            {
                decisiones.Add("PJ1", "DEFENDER");
            }
        }
        public void DecisionIa()
        {
            int decision = new Random().Next(0, 999);
            if(decision > 499)
            {
                decisiones.Add("PJ2", "ATACAR");
            }
            else
            {
                decisiones.Add("PJ2", "DEFENDER");
            }
        }
        public void CorrerTurno()
        {
            foreach(KeyValuePair<string, string> entry in decisiones)
            {
                if(entry.Key == "PJ1")
                {
                    if(entry.Value == "ATACAR")
                    {
                        GladiadorEnemigo.Vida = GladiadorEnemigo.Vida - GladiadorJugador.Fuerza;
                    }
                    else
                    {
                        GladiadorJugador.Vida = Convert.ToInt32(GladiadorJugador.Vida * 1.15);
                    }
                }
                else
                {
                    if (entry.Value == "ATACAR")
                    {
                        GladiadorJugador.Vida = GladiadorJugador.Vida - GladiadorEnemigo.Fuerza;
                    }
                    else
                    {
                        GladiadorEnemigo.Vida = Convert.ToInt32(GladiadorEnemigo.Vida * 1.15);
                    }
                }
            }
        }

        public string MostrarStatus()
        {
            string resultado = "";
            string[] resultadoEnLineas = GladiadorEnemigo.imprimirDatos().Split("\n".ToCharArray());
            foreach (string line in resultadoEnLineas)
            {
                string lineaEspaciada = "";
                for (int i = 0; i < 10; i++)
                {
                    lineaEspaciada = lineaEspaciada + "\t";
                }
                lineaEspaciada = lineaEspaciada + line;
                resultado = resultado + lineaEspaciada + "\n";
            }
                
            resultado = resultado + GladiadorJugador.imprimirDatos();
            return resultado;
        }

        public void Verificacion()
        {
            decisiones.Clear();
            if(GladiadorJugador.Vida <= 0)
            {
                Console.Clear();
                Console.WriteLine("GANO EL JUGADOR 2");
                Console.ReadKey();
                salir = true;
            }
            if (GladiadorEnemigo.Vida <= 0)
            {
                Console.Clear();
                Console.WriteLine("GANO EL JUGADOR 1");
                Console.ReadKey();
                salir = true;
            }
        }
    }
}
