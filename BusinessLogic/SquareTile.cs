namespace BusinessLogic
{
    public class SquareTile : ITile
    {
        public Material Material { get; set; }
        public int SideLength { get; set; }
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}