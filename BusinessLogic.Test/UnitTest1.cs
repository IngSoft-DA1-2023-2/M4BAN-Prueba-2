namespace BusinessLogic.Test;

[TestClass]
public class ConstalculatorTest
{
    [TestMethod]
    public void TestingNewTile()
    {
        var tile = new Tile();
        Assert.IsNotNull(tile);
    }
}