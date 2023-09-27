// See https://aka.ms/new-console-template for more information
using BusinessLogic;

var tiles = new List<Tile>();
tiles.Add(new SquareTile() { Side = 10, Material = "Cemento" });
tiles.Add(new SquareTile() { Side = 10, Material = "Ladrillo" });
var costCalculator = new CostCalculator();
var total = costCalculator.CalculateCost(tiles, 100);
Console.WriteLine(total);
