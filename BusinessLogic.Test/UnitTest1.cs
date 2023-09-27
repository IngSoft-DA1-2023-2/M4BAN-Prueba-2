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
}