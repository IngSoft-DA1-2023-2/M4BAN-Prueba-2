namespace BusinessLogic
{
    public class Tile
    {
        private string material;

        public Tile()
        {
        }

        public string Material
        {
            get => material;
            set
            {
                if (value == "Cemento" || value == "Ceramica")
                {
                    material = value;
                }
                else
                {
                    throw new ArgumentException("Material must be Cemento or Ceramica");
                }

            }
        }

        public int Side { get; set; }

        public virtual int GetArea()
        {
            return 0;
        }
    }
}