public class SquareTile : Tile
{
	public double SideLength { get; }

	public SquareTile(double sideLength, Material material) : base(material)
	{
		SideLength = sideLength;
	}

	public override double CalculateArea()
	{
		return SideLength * SideLength;
	}
}