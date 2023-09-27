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
            area = 1,
        };
        Assert.AreEqual(Shape.Square, tile.shape);
        Assert.AreEqual(Material.Cement, tile.material);
        Assert.AreEqual(1, tile.area);
    }
}