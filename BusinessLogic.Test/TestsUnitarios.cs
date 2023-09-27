using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogic.Test
{
    [TestClass]
    public class PruebasDeBaldosas
    {
        [TestMethod]
        public void TestAreaBaldosaCuadrada()
        {
            var baldosa = new BaldosaCuadrada(2, Material.Cemento);
            Assert.AreEqual(4, baldosa.Area());
        }

        [TestMethod]
        public void TestAreaBaldosaCircular()
        {
            var baldosa = new BaldosaCircular(3, Material.Cemento);
            Assert.AreEqual(Math.PI * 3 * 3, baldosa.Area());
        }

        [TestMethod]
        public void TestCostoBaldosaCuadradaCemento()
        {
            var baldosa = new BaldosaCuadrada(2, Material.Cemento);
            Assert.AreEqual(4 * 5, baldosa.Costo(1));
        }

        [TestMethod]
        public void TestCostoBaldosaCircularLadrillo()
        {
            var baldosa = new BaldosaCircular(3, Material.Ladrillo);
            Assert.AreEqual(Math.PI * 3 * 3 * 10, baldosa.Costo(1));
        }

        [TestMethod]
        public void TestCalculadoraDeCosto()
        {
            var baldosaCuadrada = new BaldosaCuadrada(2, Material.Cemento);
            var baldosaCircular = new BaldosaCircular(3, Material.Ladrillo);
            var baldosas = new List<Baldosa> { baldosaCuadrada, baldosaCuadrada, baldosaCuadrada, baldosaCircular };
            
            double costoTotal = CostCalculator.CalcularCostoTotal(baldosas, 4);
            Assert.AreEqual(3 * baldosaCuadrada.Costo(4) + baldosaCircular.Costo(4), costoTotal);
        }
    }
}
