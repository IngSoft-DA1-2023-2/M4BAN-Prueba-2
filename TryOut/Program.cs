
using BusinessLogic;
class program
{
    static void Main()
    {
        var baldosaCuadrada1 = new BaldosaCuadrada { Lado = 2, MaterialPrice = 5 };
        var baldosaCuadrada2 = new BaldosaCuadrada { Lado = 2, MaterialPrice = 5 };
        var baldosaCuadrada3 = new BaldosaCuadrada { Lado = 2, MaterialPrice = 5 };
        var baldosaCircular = new BaldosaCircular { Radio = 3, MaterialPrice = 10 };
        
        var baldosas = new List<Baldosa> { baldosaCuadrada1, baldosaCuadrada2, baldosaCuadrada3, baldosaCircular };
        
        decimal precioPorMetro = 4;

        var calculator = new CostCalculator();
        decimal totalCost = calculator.CalculateTotalCost(baldosas, precioPorMetro);
        
        Console.WriteLine($"El costo total de las baldosas es: {totalCost} pesos.");
    }
}