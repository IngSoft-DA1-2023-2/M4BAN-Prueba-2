namespace BusinessLogic.Test;

[TestClass]
public class Tile
{
    [TestMethod]
    public void TestingNewTile()
    {
        var tile = new Tile();
        Assert.IsNotNull(tile);
    }
   
}

