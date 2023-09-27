using BusinessLogic;
namespace BusinessLogic.Test;


[TestClass]
public class TileTest
{
    [TestMethod]
    public void CalculateAreaCircularTileTest()
    {
        Material material = new Material()
        {
            Name = "Ceramic",
            Cost = 10
        };
        ITile tile = new CircularTile()
        {
            Material = material,
            Radius = 10
        };
        double expected = Math.PI * 100;
        double actual = tile.CalculateArea();
        Assert.AreEqual(expected, actual);
    }
}