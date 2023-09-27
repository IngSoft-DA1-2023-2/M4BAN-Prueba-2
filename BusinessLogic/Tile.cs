namespace BusinessLogic.Test
{
    public abstract class Tile
    {
        public Material Material { get; }

        public Tile(Material material)
        {
            Material = material;
        }

        public abstract double CalculateArea();
    }
}