namespace BusinessLogic.Test;

[TestClass]
public class TileCalculatorTest
{
    [TestMethod]
    public void SquareCementTileCalculatortest()
    {
        var tile = new Tile()
        {
            Shape = Shape.Square,
            Material = Material.Cement,
            Area = 1,
        };
        var tileCalculator = new TileCalculator();
        var result = tileCalculator.CalculateSqaureCement(tile, 10);
        Assert.AreEqual(50, result);
    }
}

