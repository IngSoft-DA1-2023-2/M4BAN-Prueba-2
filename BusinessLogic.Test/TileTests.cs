namespace BusinessLogic.Test;

[TestClass]
public class TileTests
{
    [TestMethod]
    public void CreateNewTileTest()
    {
        var tile = new Tile();
        Assert.IsNotNull(tile);
    }

}