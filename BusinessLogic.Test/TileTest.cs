namespace BusinessLogic.Test;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void NewTileTest()
    {
        var tile = new Tile()
        {
            Shape = Shape.Square,
            Material = Material.Cement,
            Area = 1,
        };
        Assert.AreEqual(Shape.Square, tile.Shape);
        Assert.AreEqual(Material.Cement, tile.Material);
        Assert.AreEqual(1, tile.Area);
    }
    
    [TestMethod]
    public void TileWithNegativeAreaShouldFailTest()
    {
        var exeption = Assert.ThrowsException<ArgumentException>(() => new Tile(Shape.Square, Material.Cement, -1));
        Assert.AreEqual("Area cannot be negative", exeption.Message);
    }
    
    [TestMethod]
    public void TileWithZeroAreaShouldFailTest()
    {
        var exeption = Assert.ThrowsException<ArgumentException>(() => new Tile(Shape.Square, Material.Cement, 0));
        Assert.AreEqual("Area cannot be negative", exeption.Message);
    }
}