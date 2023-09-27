namespace BusinessLogic
{
    public class CostCalculator
    {
        public double CalculateCost(List<ITile> tiles, double pricePerMeter)
        {
           double result = 0;
           foreach (var tile in tiles)
           {
               result += tile.CalculateArea() * tile.GetMaterialPrize() * pricePerMeter;
           }                  
           return result;
        }
    }
}