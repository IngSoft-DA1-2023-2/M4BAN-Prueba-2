namespace BusinessLogic.Test;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void CalculateCost_SquareCementalTile_ShouldSucceed()
    {
        Tile squareTile = new Tile("cuadrada", 2, "cemento");
        double costPerSqm = 4;
        double expectedCost = 2 * 2 * 4 * 5; // Área * Precio por metro cuadrado * Precio del material
        double actualCost = squareTile.CalculateCost(costPerSqm);
        Assert.AreEqual(expectedCost, actualCost);
    }

    [TestMethod]
    public void CalculateCost_CircularCementalTile_ShouldSucced()
    {
        Tile circleTile = new Tile("circular", 3, "ladrillo");
        double costPerSqm = 4;
        double expectedCost = 3.14159265359 * (3 * 3) * 4 * 10; // Área * Precio por metro cuadrado * Precio del material
        double actualCost = circleTile.CalculateCost(costPerSqm);
        Assert.AreEqual(expectedCost, actualCost);
    }

    [TestMethod]
    public void CalculateCost_WithInvalidShape_ShouldThrowArgumentException()
    {
        Tile invalidTile = new Tile("triangular", 2, "cemento");
        double costPerSqm = 4;
        try
        {
            invalidTile.CalculateCost(costPerSqm);
            Assert.Fail("Se esperaba una excepción ArgumentException.");
        }
        catch (ArgumentException ex)
        {
            Assert.AreEqual("Forma de baldosa no válida", ex.Message);
        }
    }
    
    [TestMethod]
    public void CalculateCost_WithInvalidMaterial_ShouldThrowArgumentException()
    {
        Tile invalidTile = new Tile("triangular", 2, "cemento");
        double costPerSqm = 4;
        try
        {
            invalidTile.CalculateCost(costPerSqm);
            Assert.Fail("Se esperaba una excepción ArgumentException.");
        }
        catch (ArgumentException ex)
        {
            Assert.AreEqual("Forma de baldosa no válida", ex.Message);
        }
    }

}