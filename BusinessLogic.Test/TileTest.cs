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
            Size = 1,
        };
        Assert.AreEqual(Shape.Square, tile.Shape);
        Assert.AreEqual(Material.Cement, tile.Material);
        Assert.AreEqual(1, tile.Size);
    }
    
    [TestMethod]
    public void TileWithNegativeSizeShouldFailTest()
    {
        var exeption = Assert.ThrowsException<ArgumentException>(() => new Tile(Shape.Square, Material.Cement, -1));
        Assert.AreEqual("Size cannot be 0 or negative", exeption.Message);
    }
    
    [TestMethod]
    public void TileWithZeroAreaShouldFailTest()
    {
        var exeption = Assert.ThrowsException<ArgumentException>(() => new Tile(Shape.Square, Material.Cement, 0));
        Assert.AreEqual("Size cannot be 0 or negative", exeption.Message);
    }
}