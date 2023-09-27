
namespace BusinessLogic
{
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
}