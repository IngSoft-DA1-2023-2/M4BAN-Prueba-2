namespace BusinessLogic.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void NewTileTest()
    {
        var tile = new Tile();
        Assert.IsNotNull(tile);
    }

    [TestMethod]

    public void MaterialTileTest()
    {
        var tile = new Tile();
        tile.Material = "Cemento";
        Assert.AreEqual("Cemento",tile.Material);
    }
    [TestMethod]
    public void AreaTileTest()
    {
        var tile = new Tile();
        tile.Area = 0.5;
        Assert.AreEqual(0.5,tile.Area);
    }
}