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
                material = value;

            }
        }
    }
}