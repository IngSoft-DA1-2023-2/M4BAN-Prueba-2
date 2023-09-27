namespace BusinessLogic.Test;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void CalculateCost_CementalTile_ShouldSucceed()
    {
        Tile squareTile = new Tile("cuadrada", 2, "cemento");
        double costPerSqm = 4;
        double expectedCost = 2 * 2 * 4 * 5; // Área * Precio por metro cuadrado * Precio del material
        double actualCost = squareTile.CalculateCost(costPerSqm);
        Assert.AreEqual(expectedCost, actualCost);
    }

}