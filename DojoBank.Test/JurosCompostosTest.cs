using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoBank.Test
{
    [TestClass]
    public class JurosCompostosTest
    {
        [TestMethod]
        [TestCategory("Até seis meses")]
        public void TestJurosCompostos01()
        {
            var valorJurosCompostos = JurosCompostos.Calcular(10000, 4, 0.08);
            Assert.AreEqual(13604.89, valorJurosCompostos);
        }

        [TestMethod]
        [TestCategory("Até seis meses")]
        public void TestJurosCompostos02()
        {
            var valorJurosCompostos = JurosCompostos.Calcular(20000, 6, 0.03);
            Assert.AreEqual(23881.05, valorJurosCompostos);
        }

        [TestMethod]
        [TestCategory("Até um ano")]
        public void TestJurosCompostos03()
        {
            var valorJurosCompostos = JurosCompostos.Calcular(10000, 12, 0.1);

            Assert.AreEqual(31384.28, valorJurosCompostos);
        }

        [TestCategory("Até seis meses")]
        [TestMethod]
        public void TestJurosCompostos04()
        {
            var valorJurosCompostos = JurosCompostos.Calcular(50000, 6, 0.075);

            Assert.AreEqual(77165.08, valorJurosCompostos);
        }

        [TestCategory("Mais de um ano")]
        [TestMethod]
        public void TestJurosCompostos05()
        {
            var valorJurosCompostos = JurosCompostos.Calcular(45000, 24, 0.02);

            Assert.AreEqual(72379.68, valorJurosCompostos);
        }
    }
}
