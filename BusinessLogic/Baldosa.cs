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
    private string material = string.Empty;
    
    
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
    
    public string Material
    {
        get => material;
        set
        {
            if (value != "ladrillo" && value != "cemento")
            {
                throw new ArgumentException("El material de baldosa no es correcto");
            }
            material = value;
        }
    }
}

