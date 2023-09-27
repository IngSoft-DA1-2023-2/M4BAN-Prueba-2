using BusinessLogic;
namespace BusinessLogic.Test;


[TestClass]
public class CostCalculatorTest
{
    [TestClass]
    public class CostCalculatorTests
    {
        [TestMethod]
        public void CalculateTotalCost_WithSquareCementTiles()
        {
            // Arrange
            var tiles = new List<Tile>
        {
            new SquareTile(4, Material.Cement),
            new SquareTile(5, Material.Cement)
        };
            var pricePerSquareMeter = 10; // Precio por metro cuadrado

            var calculator = new CostCalculator();

            // Act
            var totalCost = calculator.CalculateTotalCost(tiles, pricePerSquareMeter);

            // Assert
            Assert.AreEqual(200, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_WithCircularBrickTiles()
        {
            // Arrange
            var tiles = new List<Tile>
        {
            new CircularTile(2, Material.Brick),
            new CircularTile(3, Material.Brick)
        };
            var pricePerSquareMeter = 10; // Precio por metro cuadrado

            var calculator = new CostCalculator();

            // Act
            var totalCost = calculator.CalculateTotalCost(tiles, pricePerSquareMeter);

            // Assert
            Assert.AreEqual(188.4, totalCost, 0.01); // Utilizamos un margen de error peque�o debido a n�meros decimales.
        }
    }
 }