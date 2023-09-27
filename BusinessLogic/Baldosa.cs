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
    private double precioMetro2;
    public double PrecioMetro2
    {
        get => precioMetro2;
        set => precioMetro2 = value;
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
            
            if(material == "ladrillo")
            {
                precioMetro2 = 10;
            }
            else
            {
                precioMetro2 = 5;
            }
        }
    }
   
}

