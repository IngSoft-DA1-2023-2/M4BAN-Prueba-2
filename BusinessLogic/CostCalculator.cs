namespace BusinessLogic;


public class CostCalculator
{
    public double CalculateTotalCost(List<Tile> tiles, double pricePerSquareMeter)
    {
        double totalCost = 0;
        foreach (var tile in tiles)
        {
            double area = tile.CalculateArea();
            double materialCost = tile.Material == Material.Cement ? 5 : 10;
            totalCost += area * pricePerSquareMeter * materialCost;
        }
        return totalCost;
    }
}