namespace BusinessLogic;

public class Tile
{
    private double _area;

    public Tile()
    {
    }
    
    public Tile (Shape shape, Material material, double area)
    {
        this.Shape = shape;
        this.Material = material;
        this.Area = area;
    }

    public Shape Shape { get; set; }
    public Material Material { get; set; }
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
    Cement = 5,
    Brick = 10
}

public enum Shape
{
    Square,
    Circle
}