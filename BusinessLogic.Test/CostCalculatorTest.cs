namespace BusinessLogic.Test;

public class CostCalculatorTest
{
    [Test]
    public void CalculateCost_SingleSquareCementTile_ReturnsCorrectCost()
    {
        // Arrange
        var costCalculator = new CostCalculator();
        var tile = new Tile
        {
            Material = Material.Cement,
            Shape = Shape.Square,
            Size = 10
        };
        
        // Act
        var cost = costCalculator.CalculateCost(tile);
        
        // Assert
        Assert.AreEqual(100, cost);
    }
    
}