// See https://aka.ms/new-console-template for more information

List<Valdosa> valdosas = new List<Valdosa>
{
    new Valdosa(2, 5, 2),
    new Valdosa(2, 5, 2),
    new Valdosa(2, 5, 2),
    new Valdosa(1, 10, 3)
};
int precioMetroCuad = 4;

CostCalculator calc = new CostCalculator();
int totalCost = calc.Calculator(valdosas, precioMetroCuad);
Console.WriteLine(totalCost);

