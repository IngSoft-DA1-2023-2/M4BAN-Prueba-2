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
        };
        Assert.AreEqual(Shape.Square, tile.shape);
    }
}



