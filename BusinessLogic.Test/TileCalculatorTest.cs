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
            Size = 1,
        };
        var tileCalculator = new TileCalculator();
        var result = tileCalculator.CalculateSqaureCement(tile, 10);
        Assert.AreEqual(50, result);
    }
    
    [TestMethod]
    public void CircleCementTileCalculatorTest()
    {
        var tile = new Tile()
        {
            Shape = Shape.Circle,
            Material = Material.Cement,
            Area = 1,
        };
        var tileCalculator = new TileCalculator();
        var result = tileCalculator.CalculateCircleCement(tile, 10);
        Assert.AreEqual(50*3.14, result);
    }

    [TestMethod]
    public void SquareBrickTileCalculatorTest()
    {
        var tile = new Tile()
        {
            Shape = Shape.Square,
            Material = Material.Brick,
            Size = 1,
        };
        var tileCalculator = new TileCalculator();
        var result = tileCalculator.CalculateSquareBrick(tile, 10);
        Assert.AreEqual(100, result);
    }
}

