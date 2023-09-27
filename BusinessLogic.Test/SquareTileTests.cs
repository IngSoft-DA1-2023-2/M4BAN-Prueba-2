
namespace BusinessLogic.Test
{
    [TestClass]
    public class SquareTileTests
    {
        [TestMethod]
        public void CreateNewSquareTileTest()
        {
            var tile = new SquareTile();
            Assert.IsNotNull(tile);
        }

        [TestMethod]
        public void SquareTileMaterialTest()
        {
            var tile = new SquareTile();
            tile.Material = "Cemento";
            Assert.AreEqual("Cemento", tile.Material);
        }

        [TestMethod]
        public void SquareTileAreaTest()
        {
            var tile = new SquareTile();
            tile.Side = 2;
            Assert.AreEqual(4, tile.GetArea());
        }

    }
}
