namespace BusinessLogic;

public class Tile
{
    public Tile(TileData data)
    {
        Material = data.Material;
        Area = data.Area;
    }

    public string Material
    { 
        get=> Material;
        set
        {
            if (value == "Ladrillo" && value == "Cemento") {
                
                Material = value;
            
            }
            else
            {
                throw new ArgumentException("Material no valido");
            }


        }

            
    }
    public double Area { get; set; }

}