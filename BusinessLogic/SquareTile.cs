namespace BusinessLogic
{
    public class SquareTile : Tile
    {

        public SquareTile()
        {
        }

        public override int GetArea()
        {
            return Side * Side;
        }
    }
}