namespace BusinessLogic
{
    public class Tile
    {
        private string material;

        public Tile()
        {
        }

        public int Area { get; set; }
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
    }
}