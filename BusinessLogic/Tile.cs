namespace BusinessLogic;

public class Tile
{
    private int _size;

    public Tile()
    {
    }
    
    public Tile (Shape shape, Material material, int size)
    {
        Shape = shape;
        Material = material;
        Size = size;
    }

    public double Area { get; set; }
    public Shape Shape { get; set; }
    public Material Material { get; set; }

    public int Size
    {
        get => _size;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Size cannot be 0 or negative");
            }
            _size = value;
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