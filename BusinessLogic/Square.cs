
namespace BusinessLogic
{
    public class SquareTile : Tile
    {
        private double _sideLength;

        public SquareTile(double sideLength)
        {
            _sideLength = sideLength;
        }

        public override double GetArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
