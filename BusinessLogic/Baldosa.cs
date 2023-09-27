namespace BusinessLogic;

public class Baldosa
{
    public Baldosa()
    {
        
    }
    public Baldosa(string tipo, string material)
    {
        Tipo = tipo;
        Material = material;
    }
    public string Tipo { get; set; }
    public string Material { get; set; }
}

