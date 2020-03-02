using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Coliseum;

namespace ColiseumTest
{
    class TestGladiador
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test001_MostrarInformacionGladiador()
        {
            Factory factory = new Factory();
            Gladiador gladiador = factory.gladiadorVacio();
            Assert.IsNotNull(gladiador.imprimirDatos());
        }
    }
}
