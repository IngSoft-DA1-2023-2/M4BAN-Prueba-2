

namespace BusinessLogic
{
    public class CostCalculator
    {
        public double CalculateCost(List<Tile> tiles, double CostMetroCuadrado)
        {
            double total = 0;
            foreach (var tile in tiles)
            {
                if(tile.Material == "Cemento")
                {
                    total += tile.GetArea() * CostMetroCuadrado * 5;
                }
                else if (tile.Material == "Ladrillo")
                {
                    total += tile.GetArea() * CostMetroCuadrado * 10;
                }
                else
                {
                    throw new ArgumentException("Material must be Cemento or Ceramica");
                }
                
            }

            return total;
        }
    }
}
