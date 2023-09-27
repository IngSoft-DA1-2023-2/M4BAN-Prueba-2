namespace BusinessLogic;

public class CostCalculator
{
    public int Calculator(List<Valdosa> valdosas, int precioMetroCuad)
    {
        int totalCost = 0;
        foreach (var valdosa in valdosas)
        {
            int area = 0;
            if (valdosa.Tipo == 1)
            {
                area = (int) (Math.PI * Math.Pow(valdosa.Tamano, 2));
            }
            else if (valdosa.Tipo == 2)
            {
                area = (int) Math.Pow(valdosa.Tamano, 2);
            }

            int cost = area * precioMetroCuad * valdosa.Material;
            totalCost += cost;
        }

        return totalCost;
    }
}