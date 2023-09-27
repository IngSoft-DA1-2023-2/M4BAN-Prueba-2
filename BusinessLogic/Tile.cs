namespace BusinessLogic;

public class Tile
{
    private string Shape { get; }
    private double Size { get; }
    private string Material { get; }

    public Tile(string shape, double size, string material)
    {
        Shape = shape;        // cuadrada o circular
        Size = size;          // Tamaño (lado para cuadradas, radio para circulares)
        Material = material;  // Material de la baldosa (cemento o ladrillo)
    }
    public double CalculateCost(double pricePerSqm)
    {
        double area = 0;
        if (Shape == "cuadrada")
        {
            area = Size * Size;
        }
        else if (Shape == "circular")
        {
            area = 3.14159265359 * (Size * Size);
        }
        else
        {
            throw new ArgumentException("Forma de baldosa no válida");
        }

        double materialPrice = 0;
        if (Material == "cemento")
        {
            materialPrice = 5;
        }
        else if (Material == "ladrillo")
        {
            materialPrice = 10;
        }
        else
        {
            throw new ArgumentException("Material de baldosa no válido");
        }

        double cost = area * pricePerSqm * materialPrice;
        return cost;
    }
}