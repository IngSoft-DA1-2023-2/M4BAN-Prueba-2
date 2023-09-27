namespace BusinessLogic.Test;

public class TileTest
{
    [Test]
    public void CalculateCost_CementalTile_ShouldSuccess()
    {
        Tile squareTile = new Tile("cuadrada", 2, "cemento");
        double costPerSqm = 4;
        double expectedCost = 2 * 2 * 4 * 5; // Área * Precio por metro cuadrado * Precio del material
        double actualCost = squareTile.CalculateCost(costPerSqm);
        Assert.AreEqual(expectedCost, actualCost);
    }

}