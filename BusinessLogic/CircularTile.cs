namespace BusinessLogic;

public class CircularTile : Tile
{
    public double Radius { get; }

    public CircularTile(double radius, Material material) : base(material)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}