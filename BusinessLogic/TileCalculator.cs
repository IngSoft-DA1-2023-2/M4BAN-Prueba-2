namespace BusinessLogic;

public class TileCalculator
{
    public double CalculateSqaureCement(Tile tile, int price)
    {
        if (tile.Shape != Shape.Square)
        {
            throw new ArgumentException("Shape must be square");
        }
        if (tile.Material != Material.Cement)
        {
            throw new ArgumentException("Material must be cement");
        }
        double area = tile.Size * tile.Size;
        return area * price * (double)tile.Material;
    }
    
    public double CalculateCircleCement(Tile tile, int price)
    {
        if (tile.Shape != Shape.Circle)
        {
            throw new ArgumentException("Shape must be circle");
        }
        if (tile.Material != Material.Cement)
        {
            throw new ArgumentException("Material must be cement");
        }
        double area = 3.14 * tile.Size * tile.Size;
        return area * price * (double)tile.Material;
    }
    
    public double CalculateSquareBrick(Tile tile, int price)
    {
        if (tile.Shape != Shape.Square)
        {
            throw new ArgumentException("Shape must be square");
        }
        if (tile.Material != Material.Brick)
        {
            throw new ArgumentException("Material must be brick");
        }
        double area = tile.Size * tile.Size;
        return area * price * (double)tile.Material;
    }
}
