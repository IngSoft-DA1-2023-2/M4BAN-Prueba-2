
namespace BusinessLogic.Test
{
    [TestClass]
    public class RoundTileTests
    {
        [TestMethod]
        public void CreateNewRoundTileTest()
        {
            var tile = new RoundTile();
            Assert.IsNotNull(tile);
        }

    }
}
