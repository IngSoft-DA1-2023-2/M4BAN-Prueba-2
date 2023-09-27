namespace BusinessLogic;

public class TileCalculator
{
    public int CalculateSqaureCement(Tile tile, int price)
    {
        if (tile.Shape != Shape.Square)
        {
            throw new ArgumentException("Shape must be square");
        }
        if (tile.Material != Material.Cement)
        {
            throw new ArgumentException("Material must be cement");
        }

        return (int)(tile.Area * price * (double)tile.Material);
    }
}
