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
    private string tipo = string.Empty;

    public string Material { get; set; }
    
    public string Tipo
    {
        get => tipo;
        set
        {
            if (value != "circular" && value != "cuadrada")
            {
                throw new ArgumentException("El tipo de baldosa no es correcto");
            }

            tipo = value;
        }
    }
}

