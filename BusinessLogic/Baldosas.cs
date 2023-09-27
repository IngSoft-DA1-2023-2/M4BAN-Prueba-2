
namespace BusinessLogic
{
    public enum Material
    {
        Cemento = 5,
        Ladrillo = 10 
    }

    public abstract class Baldosa
    {
        protected Material MaterialBaldosa { get; set; }

        public Baldosa(Material material)
        {
            this.MaterialBaldosa = material;
        }

        public abstract double Area();

        public double Costo(double precioPorMetroCuadrado)
        {
            return Area() * precioPorMetroCuadrado * (double)MaterialBaldosa;
        }
    }

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

    public class BaldosaCircular : Baldosa
    {
        public double Radio { get; set; }

        public BaldosaCircular(double radio, Material material) : base(material)
        {
            this.Radio = radio;
        }

        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }
    }

    public class CostCalculator
    {
        public static double CalcularCostoTotal(List<Baldosa> baldosas, double precioPorMetroCuadrado)
        {
            double costoTotal = 0;

            foreach (var baldosa in baldosas)
            {
                costoTotal += baldosa.Costo(precioPorMetroCuadrado);
            }

            return costoTotal;
        }
    }
}