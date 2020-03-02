using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    public class Tienda
    {
        public List<Gladiador> GladiadoresDisponibles { get; set; }
        public List<Gladiador> GladiadoresComprados = new List<Gladiador>();

        public Tienda()
        {
            GladiadoresDisponibles = new List<Gladiador>();
        }
        public void GenerarLuchadoresRandoms()
        {
            GladiadoresDisponibles.Clear();
            for (int i = 0; i < 4; i++)
            {
                GladiadoresDisponibles.Add(new Gladiador {Vida = new Random().Next(800, 1100),Fuerza = new Random().Next(80, 110), Precio = new Random().Next(700, 1200) }) ;
                System.Threading.Thread.Sleep(20);
            }
        }

        public List<Gladiador> Menu()
        {
            GenerarLuchadoresRandoms();
            bool salir = false;
            do
            {
                Console.Clear();
                foreach (Gladiador luchador in GladiadoresDisponibles)
                {
                    Console.WriteLine(luchador.imprimirDatos());
                }
                imprimirMenuCompra();
                try
                {
                    int decision = Int32.Parse(Console.ReadLine());
                    if(decision != GladiadoresDisponibles.Count + 1)
                    {
                        compraGladiador(decision);
                    }
                    else
                    {
                        salir = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor escriba un numero");
                    Console.ReadKey();
                }
            } while (!salir);
            return GladiadoresComprados;
        }

        public void imprimirMenuCompra()
        {
            int contador = 0;
            foreach(Gladiador gladiador in GladiadoresDisponibles)
            {
                contador++;
                Console.WriteLine(contador+".Comprar");
            }
            Console.WriteLine(contador + 1 +".Salir");
        }
        public void compraGladiador(int seleccion)
        {
            GladiadoresComprados.Add(GladiadoresDisponibles[seleccion - 1]);
            GladiadoresDisponibles.RemoveAt(seleccion - 1);
        }
    }
}
