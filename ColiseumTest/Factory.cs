using System;
using System.Collections.Generic;
using System.Text;
using Coliseum;
using Coliseum.Torneos;

namespace ColiseumTest
{
    public class Factory
    {
        public Gladiador gladiadorVacio()
        {
            return new Gladiador();
        }

        public Tienda tiendaVacia()
        {
            return new Tienda();
        } 

        public Encuentro encuentroVacio()
        {
            return new Encuentro();
        }

        public Gladiador gladiadorValoresRandoms()
        {
            return new Gladiador { Vida = new Random().Next(80, 110), Fuerza = new Random().Next(80, 110), Precio = new Random().Next(700, 1200) };
        }

        public Encuentro encuentroConGladiadoresRandoms()
        {
            return new Encuentro { GladiadorEnemigo = gladiadorValoresRandoms(), GladiadorJugador = gladiadorValoresRandoms() };
        }
    }
}
