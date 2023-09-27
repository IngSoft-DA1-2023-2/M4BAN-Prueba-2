namespace BusinessLogic;

public class CostCalculator
{
    public static double CalculateTotalCost(List<Tile> tiles, double pricePerSqm)
    {
        double totalCost = 0;
        foreach (Tile tile in tiles)
        {
            totalCost += tile.CalculateCost(pricePerSqm);
        }
        return totalCost;
    }
    
}