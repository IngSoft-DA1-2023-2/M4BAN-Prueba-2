

namespace BusinessLogic.Test;

[TestClass]
public class TileTest
{

    [TestMethod]
    public void NewTileTest()
    {
        var tile = new TileData();
        Assert.IsNotNull(tile);
    }

    [TestMethod]

    public void MaterialTileTest()
    {
        var tile = new TileData();
        tile.Material = "Cemento";
        Assert.AreEqual("Cemento",tile.Material);
    }
    [TestMethod]
    public void AreaTileTest()
    {
        var tile = new TileData();
        tile.Area = 0.5;
        Assert.AreEqual(0.5,tile.Area);
    }

    [TestMethod]
    public void WrongMaterialTileTest()
    {
        var tileData = new TileData
        {
            Material = "Madera",
            Area = 0.5

        };
        var exception = Assert.ThrowsException<ArgumentException>(() => new Tile(tileData));
        Assert.AreEqual("Material no valido", exception.Message);
    }
    
}