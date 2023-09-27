
namespace BusinessLogic
{
    public class CostCalculator
    {
        public static double CalcularCostoTotal(List<Baldosa> baldosas, double precioPorMetroCuadrado)
        {
            double costoTotal = 0;

            foreach (var baldosa in baldosas)
            {
                costoTotal += baldosa.Costo(precioPorMetroCuadrado);
            }

            return costoTotal;
        }
    }
}