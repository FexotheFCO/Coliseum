using Coliseum.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    class Program
    {
        static Partida PartidaSelecionada;
        static List<Partida> Partidas = new List<Partida>();
        static void Main(string[] args)
        {
            SistemaCargaLectura scl = new SistemaCargaLectura();
            Partidas = scl.cargarPartidas();
            MenuPrincipal();
        }
        static string Inicio()
        {
            string resultado;
            resultado = @"    __   ___   _      ____   _____   ___  __ __  ___ ___     " + "\n" +
                        @"   /  ] /   \ | |    |    | / ___/  /  _]|  |  ||   |   |    " + "\n" +
                        @"  /  / |     || |     |  | (   \_  /  [_ |  |  || _   _ |    " + "\n" +
                        @" /  /  |  O  || |___  |  |  \__  ||    _]|  |  ||  \_/  |    " + "\n" +
                        @"/   \_ |     ||     | |  |  /  \ ||   [_ |  :  ||   |   |    " + "\n" +
                        @"\     ||     ||     | |  |  \    ||     ||     ||   |   |    " + "\n" +
                        @" \____| \___/ |_____||____|  \___||_____| \__,_||___|___|    " + "\n";
            return resultado;
        }
        static void MenuPrincipal()
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine(Inicio());
                Console.WriteLine("1.Un Jugador\n2.Multijugador\n3.Salir");
                try
                {
                    int decision = Int32.Parse(Console.ReadLine());
                    switch (decision)
                    {
                        case 1:
                            UnJugador();
                            break;
                        case 2:
                            break;
                        case 3:
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

        static void UnJugador()
        {
            bool salir = false;
            do
            {
                Console.Clear();
                foreach(Partida partida in Partidas)
                {
                    Console.WriteLine(partida.Nombre);
                }
                Console.WriteLine("1.Nueva Partida\n2.Cargar\n3.Salir\n4.Guardar");
                try
                {
                    int decision = Int32.Parse(Console.ReadLine());
                    switch (decision)
                    {
                        case 1:
                            NuevaPartida();
                            break;
                        case 2:
                            Cargar();
                            break;
                        case 3:
                            salir = true;
                            break;
                        case 4:
                            Guardar();
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
        static void NuevaPartida()
        { 
            //Se crea la partida
            Console.WriteLine("Escriba el nombre de la nueva partida");
            string nombre = Console.ReadLine();
            Partidas.Add(new Partida(nombre));
            //Se guarda la partida
            SistemaCargaLectura scl = new SistemaCargaLectura();
            scl.guardarPartidas(Partidas);
            //Se corre el menu de la primera partida en partidas
            PartidaSelecionada = Partidas[0];
            PartidaSelecionada.CorrerMenu();
        }
        static void Cargar()
        {

        }

        static void Guardar()
        {
            SistemaCargaLectura scl = new SistemaCargaLectura();
            scl.guardarPartidas(Partidas);
        }

        static void SeleccionarPartida()
        {
            foreach(Partida partida in Partidas)
            {
                Console.WriteLine(partida.Nombre);
            }
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Seleccionar\n2.Seleccionar\n3.Seleccionar\n4.Guardar");
                try
                {
                    int decision = Int32.Parse(Console.ReadLine());
                    switch (decision)
                    {
                        case 1:
                            NuevaPartida();
                            break;
                        case 2:
                            Cargar();
                            break;
                        case 3:
                            salir = true;
                            break;
                        case 4:
                            Guardar();
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
    }
} 
