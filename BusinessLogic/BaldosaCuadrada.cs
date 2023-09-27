
namespace BusinessLogic
{
    public class BaldosaCuadrada : Baldosa
    {
        public double Lado { get; set; }

        public BaldosaCuadrada(double lado, Material material) : base(material)
        {
            this.Lado = lado;
        }

        public override double Area()
        {
            return Lado * Lado;
        }
    }
}