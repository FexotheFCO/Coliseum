using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Coliseum;

namespace ColiseumTest
{
    class TestTienda
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test001_TiendaCrea4GladiadoresRandoms()
        {
            Factory factory = new Factory();
            Tienda tiendaDeGladiadores = new Tienda();
            Assert.AreEqual(0, tiendaDeGladiadores.GladiadoresDisponibles.Count);
            tiendaDeGladiadores.GenerarLuchadoresRandoms();
            Assert.AreEqual(4, tiendaDeGladiadores.GladiadoresDisponibles.Count);
        }
        [Test]
        public void Test002_ComprarGladiador()
        {
            Factory factory = new Factory();
            Tienda tiendaDeGladiadores = new Tienda();
            tiendaDeGladiadores.GenerarLuchadoresRandoms();
            tiendaDeGladiadores.compraGladiador(1);
            Assert.AreEqual(1, tiendaDeGladiadores.GladiadoresComprados.Count);
        }
        [Test]
        public void Test003_ComprarVariosGladiadores()
        {
            Factory factory = new Factory();
            Tienda tiendaDeGladiadores = new Tienda();
            tiendaDeGladiadores.GenerarLuchadoresRandoms();
            tiendaDeGladiadores.compraGladiador(1);
            tiendaDeGladiadores.compraGladiador(3);
            Assert.AreEqual(2, tiendaDeGladiadores.GladiadoresComprados.Count);
        }
    }
}
