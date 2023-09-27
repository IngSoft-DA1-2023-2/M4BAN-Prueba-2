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

    [TestMethod]
    public void CalculateAreaSquareTileTest()
    {
        Material material = new Material()
        {
            Name = "Ceramic",
            Cost = 10
        };
        ITile tile = new SquareTile()
        {
            Material = material,
            SideLength = 10
        };
        double expected = 100;
        double actual = tile.CalculateArea();
        Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void CalculateCostTilesTest()
    {
        Material material = new Material()
        {
            Name = "Ceramic",
            Cost = 10
        };
        ITile tile = new SquareTile()
        {
            Material = material,
            SideLength = 10
        };
        List<ITile> tiles = new List<ITile>()
        {
            tile,
        };
        double pricePerMeter = 10;
        double expected = 10000;
        CostCalculator costCalculator = new CostCalculator();
        double result = costCalculator.CalculateCost(tiles,pricePerMeter);
        Assert.AreEqual(expected, result);
    }
}