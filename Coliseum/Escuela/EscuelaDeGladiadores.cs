using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coliseum.Torneos;
using Newtonsoft.Json;

namespace Coliseum
{
    public class EscuelaDeGladiadores
    {
        
        public List<Gladiador> Gladiadores { get; set; }
        Tienda tiendaDeGladiadores{ get; set; }
        public string Nombre { get; set; }



        [JsonConstructor]
        public EscuelaDeGladiadores()
        {

        }
        public EscuelaDeGladiadores(string nombre)
        {
            Gladiadores = new List<Gladiador>();
            this.Nombre = nombre;   
        }
        public void Menu()
        {
            tiendaDeGladiadores = new Tienda();
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Ir a la tienda de gladiadores\n2.Mostrar gladiadores\n3.Torneos\n4.Salir");
                try
                {
                    int decision = Int32.Parse(Console.ReadLine());
                    switch (decision)
                    {
                        case 1:
                            irALaTiendaDeGladiadores();
                            break;
                        case 2:
                            mostrarGladiadores();
                            Console.ReadKey();
                            break;
                        case 3:
                            irANuevoEncuentro();
                            break;
                        case 4:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Por favor elija una opcion correcta");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor escriba un numero");
                    Console.ReadKey();
                }
            } while (!salir);
        }

        void irALaTiendaDeGladiadores()
        {
            foreach(Gladiador gladiador in tiendaDeGladiadores.Menu())
            {
                Gladiadores.Add(gladiador);
            }
        }
        void VenderGladiador()
        {

        }
        void InspeccionarGladiador()
        {

        }

        void mostrarGladiadores()
        {
            try
            {
                foreach (Gladiador gladiador in Gladiadores)
                {
                    Console.WriteLine(gladiador.imprimirDatos());
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No tienes ningun Gladiador");
                Console.ReadKey();
            }            
        }

        void irANuevoEncuentro()
        {
            Encuentro encuentro = new Encuentro { GladiadorJugador = Gladiadores[0], GladiadorEnemigo = new Gladiador { Vida = new Random().Next(800, 1100), Fuerza = new Random().Next(80, 110), Precio = new Random().Next(700, 1200) } };
            encuentro.Menu();
        }
    }
}
