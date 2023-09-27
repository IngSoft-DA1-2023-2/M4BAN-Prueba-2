// See https://aka.ms/new-console-template for more information

using BusinessLogic;

Console.WriteLine("Hello, World!");

// En TryOut, se pide calcular el precio de 3 baldosas cuadradas de 2x2 de cemento y 1 circular de radio=3 de ladrillo, a 4 pesos el metro cuadrado.

Tile squareTile1 = new Tile("cuadrada", 2, "cemento");
Tile squareTile2 = new Tile("cuadrada", 2, "cemento");
Tile squareTile3 = new Tile("cuadrada", 2, "cemento");
Tile circleTile = new Tile("circular", 3, "ladrillo");

List<Tile> tiles = new List<Tile> { squareTile1, squareTile2, squareTile3, circleTile };

double pricePerSqm = 4;
double totalCost = CostCalculator.CalculateTotalCost(tiles, pricePerSqm);

Console.WriteLine($"El precio total es {totalCost}");