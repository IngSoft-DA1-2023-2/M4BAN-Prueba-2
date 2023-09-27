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
}