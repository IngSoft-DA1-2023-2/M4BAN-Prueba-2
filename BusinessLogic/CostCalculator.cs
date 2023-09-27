namespace BusinessLogic;

public class CostCalculator
{
    public decimal CalculateTotalCost(List<Baldosa> baldosas, decimal precioPorMetro)
    {
        decimal totalCost = 0;

        foreach (var baldosa in baldosas)
        {
            decimal area = baldosa.CalculateArea();
            decimal baldosaCost = area * precioPorMetro * baldosa.MaterialPrice;
            totalCost += baldosaCost;
        }

        return totalCost;
    }
}
public abstract class Baldosa
{
    public decimal MaterialPrice { get; set; }

    public abstract decimal CalculateArea();
}

public class BaldosaCuadrada : Baldosa
{
    public int Lado { get; set; }

    public override decimal CalculateArea()
    {
        return Lado * Lado;
    }
}

public class BaldosaCircular : Baldosa
{
    public double Radio { get; set; }

    public override decimal CalculateArea()
    {
        return (decimal)(Math.PI * Radio * Radio);
    }
}