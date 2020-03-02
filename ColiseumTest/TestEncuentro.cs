using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Coliseum;
using Coliseum.Torneos;

namespace ColiseumTest
{
    class TestEncuentro
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test001_JugadorAtaca()
        {
            Factory factory = new Factory();
            Encuentro encuentro = factory.encuentroConGladiadoresRandoms();
            encuentro.Decision(1);
            Assert.AreEqual("ATACAR", encuentro.decisiones["PJ1"]);
        }
        [Test]
        public void Test002_JugadorDefiende()
        {
            Factory factory = new Factory();
            Encuentro encuentro = factory.encuentroConGladiadoresRandoms();
            encuentro.Decision(2);
            Assert.AreEqual("DEFENDER", encuentro.decisiones["PJ1"]);
        }
        [Test]
        public void Test003_DecisionRandomIa()
        {
            Factory factory = new Factory();
            Encuentro encuentro = factory.encuentroConGladiadoresRandoms();
            encuentro.DecisionIa();
            Assert.IsTrue("ATACAR" == encuentro.decisiones["PJ2"] || "Defender" == encuentro.decisiones["PJ2"]);
        }
        [Test]
        public void Test004_CorrerTurnoAtaque()
        {
            Factory factory = new Factory();
            Encuentro encuentro = factory.encuentroConGladiadoresRandoms();
            encuentro.Decision(1);
            encuentro.DecisionIa();
            int vidaEnemigoAntesDelTurno = encuentro.GladiadorEnemigo.Vida;
            encuentro.CorrerTurno();
            Assert.IsTrue(vidaEnemigoAntesDelTurno > encuentro.GladiadorEnemigo.Vida);
        }
        [Test]
        public void Test005_CorrerTurnoDefensa()
        {
            Factory factory = new Factory();
            Encuentro encuentro = factory.encuentroConGladiadoresRandoms();
            encuentro.Decision(2);
            encuentro.DecisionIa();
            int vidaEnemigoAntesDelTurno = encuentro.GladiadorEnemigo.Vida;
            encuentro.CorrerTurno();
            Assert.IsTrue(vidaEnemigoAntesDelTurno == encuentro.GladiadorEnemigo.Vida);
        }
    }
}
