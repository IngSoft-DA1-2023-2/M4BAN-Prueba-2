namespace BusinessLogic.Test;

[TestClass]
public class TileTest
{
    [TestMethod]
    public void NewTileTest()
    {
        var tile = new Tile()
        {
            shape = Shape.Square,
            material = Material.Cement,
            Area = 1,
        };
        Assert.AreEqual(Shape.Square, tile.shape);
        Assert.AreEqual(Material.Cement, tile.material);
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