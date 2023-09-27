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
        var result = tileCalculator.Calculate(tile);
        Assert.AreEqual(1, result);
    }
}

