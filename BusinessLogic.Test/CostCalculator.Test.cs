namespace BusinessLogic.Test;
using BusinessLogic;

[TestClass]
public class CostCalculatorTest
{
    public object Material { get; private set; }

    [TestMethod]
    public void CalculateTotalCost_SquareTile()
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
    public void CalculateTotalCost_CircularTiles()
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
        Assert.AreEqual(188.4, totalCost, 0.01); // Utilizamos un margen de error pequeño debido a números decimales.
    }
}

internal class SquareTile
{
    private int v;
    private object cement;

    public SquareTile(int v, object cement)
    {
        this.v = v;
        this.cement = cement;
    }
}