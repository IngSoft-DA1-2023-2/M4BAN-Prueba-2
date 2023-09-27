namespace BusinessLogic.Test;

[TestClass]
public class CostCalculatorTest
{
  [TestMethod]
  public void CalculateTotalCost_ForEmptyTileList_ShouldReturnZero()
  {
    // Arrange
    List<Tile> tiles = new List<Tile>();
    double pricePerSqm = 5;

    // Act
    double totalCost = CostCalculator.CalculateTotalCost(tiles, pricePerSqm);

    // Assert
    Assert.AreEqual(0, totalCost);
  }
  
  [TestMethod]
  public void CalculateTotalCost_ForOneSquareCementTile_ShouldReturnCorrectCost()
  {
    // Arrange
    List<Tile> tiles = new List<Tile>
    {
      new Tile("cuadrada", 2, "cemento")
    };
    double pricePerSqm = 5;

    // Act
    double totalCost = CostCalculator.CalculateTotalCost(tiles, pricePerSqm);

    // Assert
    Assert.AreEqual(2 * 2 * 5 * 5, totalCost);
  }


  [TestMethod]
  public void CalculateTotalCost_ForMultipleTiles_ShouldReturnCorrectTotalCost()
  {
    // Arrange
    List<Tile> tiles = new List<Tile>
    {
      new Tile("cuadrada", 2, "cemento"),
      new Tile("circular", 3, "ladrillo"),
      new Tile("cuadrada", 4, "ladrillo")
    };
    double pricePerSqm = 5;

    // Act
    double totalCost = CostCalculator.CalculateTotalCost(tiles, pricePerSqm);

    // Assert
    Assert.AreEqual(2 * 2 * 5 * 5 + 3.14 * (3 * 3) * 5 * 10 + 4 * 4 * 5 * 10, totalCost);
  }
}