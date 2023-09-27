// See https://aka.ms/new-console-template for more information

using BusinessLogic;

namespace TryOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var baldosaCuadrada1 = new BaldosaCuadrada(2, Material.Cemento);
            var baldosaCuadrada2 = new BaldosaCuadrada(2, Material.Cemento);
            var baldosaCuadrada3 = new BaldosaCuadrada(2, Material.Cemento);
            var baldosaCircular = new BaldosaCircular(3, Material.Ladrillo);

            var baldosas = new List<Baldosa>
            {
                baldosaCuadrada1,
                baldosaCuadrada2,
                baldosaCuadrada3,
                baldosaCircular
            };

            double precioPorMetroCuadrado = 4;
            double costoTotal = CostCalculator.CalcularCostoTotal(baldosas, precioPorMetroCuadrado);

            Console.WriteLine($"El costo total de las baldosas es: {costoTotal} pesos.");
        }
    }
}
