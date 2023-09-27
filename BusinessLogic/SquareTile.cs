namespace BusinessLogic
{
    public class SquareTile : Tile
    {

        public SquareTile()
        {
        }

        public override double GetArea()
        {
            return Side * Side;
        }
    }
}