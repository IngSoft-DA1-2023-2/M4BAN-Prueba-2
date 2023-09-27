namespace BusinessLogic;

public class Tile
{
    private double _area;

    public Tile()
    {
    }
    
    public Tile (Shape shape, Material material, double area)
    {
        this.shape = shape;
        this.material = material;
        this.Area = area;
    }

    public Shape shape { get; set; }
    public Material material { get; set; }
    public double Area 
    { 
        get => _area;
        set
        {
            if (value < 0 || value == 0)
            {
                throw new ArgumentException("Area cannot be negative");
            }
            _area = value;
        }
    }
}

public enum Material
{
    Cement,
    Brick
}

public enum Shape
{
    Square,
    Circle
}