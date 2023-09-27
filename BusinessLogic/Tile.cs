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
        if (shape == Shape.Square)
        {
            this.Area = Size * Size;
        }
        else if (shape == Shape.Square)
        {
            this.Area = Double.Pi * Size * Size;
        }
        
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

    public int Size { get; set; }
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