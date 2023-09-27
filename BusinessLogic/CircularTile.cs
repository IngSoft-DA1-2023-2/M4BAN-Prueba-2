namespace BusinessLogic
{
    public class CircularTile : ITile
    {

        public int Radius { get; set; }
        public Material Material { get; set; }
        public double CalculateArea()
        {
            throw new System.NotImplementedException();
        }
    }
}