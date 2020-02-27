using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            Console.Read();
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
                        break;
                }
            } while (!salir);
        }

        static void UnJugador()
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Nueva Partida\n2.Cargar\n3.Salir");
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
                    default:
                        Console.WriteLine("Por favor elija una opcion correcta");
                        break;
                }
            } while (!salir);
        }
        static void NuevaPartida()
        {

        }
        static void Cargar()
        {

        }
    }
} 
