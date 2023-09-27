namespace BusinessLogic;

public class Tile
{
    public Shape shape { get; set; }
    public Material material { get; set; }
    public double area { get; set; }
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