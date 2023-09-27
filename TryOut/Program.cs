// See https://aka.ms/new-console-template for more information

using BusinessLogic;

var baldosa1 = new Baldosa("Cuadrado", 2, "Cemento");
var baldosa2 = new Baldosa("Cuadrado", 2, "Cemento");
var baldosa3 = new Baldosa("Cuadrado", 2, "Cemento");
var baldosa4 = new Baldosa("Circulo", 3, "Ladrillo");

var listaBaldosas = new List<Baldosa>
{
    baldosa1,
    baldosa2,
    baldosa3,
    baldosa4
};

var precioMetroCuadrado = 4;
var costCalculator = new CostCalculator();
var totalCost = costCalculator.CalculateTotalCost(listaBaldosas, precioMetroCuadrado);

Console.WriteLine("El costo total de las baldosas es: " + totalCost);