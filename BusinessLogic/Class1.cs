namespace BusinessLogic;

public abstract class Tile
{
    protected IMaterial Material;

    public Tile(IMaterial material)
    {
        Material = material;
    }

    public abstract double GetArea();

    public double GetCost(double pricePerSquareMeter)
    {
        return GetArea() * pricePerSquareMeter * Material.Price;
    }
}
