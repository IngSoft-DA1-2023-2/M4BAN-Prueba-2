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
    public void TileMaterialTest()
    {
        var tile = new Tile();
        tile.Material = "Cemento";
        Assert.AreEqual("Cemento", tile.Material);
    }

    [TestMethod]
    public void TileMaterialShouldNotBeOtherThanCementoOrCeramicaTest()
    {
        var tile = new Tile();
        Assert.ThrowsException<ArgumentException>(() => tile.Material = "Madera");
    }

    [TestMethod]
    public void TileSideTest()
    {
        var tile = new Tile();
        tile.Side = 1;
        Assert.AreEqual(1, tile.Side);
    }

}