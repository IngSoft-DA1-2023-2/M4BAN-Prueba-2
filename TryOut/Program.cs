using BusinessLogic;

class Program
{
    static void Main(string[] args)
    {
        Material cement = new Material()
        {
            Name = "Cement",
            Cost = 5
        };
        ITile tile = new SquareTile()
        {
            Material = cement,
            SideLength = 2
        };

        Material ladrillo = new Material()
        {
            Name = "ladrillo",
            Cost = 5
        };
        ITile circleTile = new CircularTile()
        {
            Material = ladrillo,
            Radius = 3
        };
        List<ITile> tiles = new List<ITile>()
        {
            tile,
            tile,
            tile,
            circleTile,
        };
        CostCalculator calculator = new CostCalculator();
        Console.Write(calculator.CalculateCost(tiles,3));
    }
}