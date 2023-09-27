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

    [TestMethod]
    public void TileAreaTest()
    {
        var tile = new Tile();
        tile.Area = 1;
        Assert.AreEqual(1, tile.Area);
    }

    [TestMethod]
    public void TileMaterialTest()
    {
        var tile = new Tile();
        tile.Material = "Cemento";
        Assert.AreEqual("Cemento", tile.Material);
    }

}