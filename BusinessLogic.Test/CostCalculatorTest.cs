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


}