
namespace BusinessLogic
{
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
}