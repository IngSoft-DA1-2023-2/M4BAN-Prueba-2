namespace BusinessLogic;

public class CostCalculator
{
    public int CalculateCost(int largo, int ancho, int costoPorMetroCuadrado)
    {
        return largo * ancho * costoPorMetroCuadrado;
    }
    
}