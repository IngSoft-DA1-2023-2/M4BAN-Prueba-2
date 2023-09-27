namespace BusinessLogic
{
    public class SquareTile : ITile
    {
        public Material Material { get; set; }
        public int SideLength { get; set; }
        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}