namespace BusinessLogic
{
    public class Tile
    {
        private string material;

        public Tile()
        {
            material = "Cemento";
        }

        public string Material
        {
            get => material;
            set
            {
                if (value == "Cemento" || value == "Ladrillo")
                {
                    material = value;
                }
                else
                {
                    throw new ArgumentException("Material must be Cemento or Ceramica");
                }

            }
        }

        public double Side { get; set; }

        public virtual double GetArea()
        {
            return 0;
        }
    }
}