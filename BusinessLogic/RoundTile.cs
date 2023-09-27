namespace BusinessLogic.Test
{
    public class RoundTile : Tile
    {
        public RoundTile()
        {
        }

        public override double GetArea()
        {
            return Math.PI * Side * Side;
        }
    }
}