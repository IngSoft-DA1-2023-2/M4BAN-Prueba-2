namespace BusinessLogic;

public class Valdosa
{
    private int _tipo;
    private int _material;
    private int _tamano;
    
    public int Tipo
    {
        get => _tipo;
        private set
        {
            if (value != 1 && value != 2)
            {
                throw new ArgumentException("Tipo must be 1(circular) or 2(cuadrada)");
            }

            _tipo = value;
        }
    }
    
    public int Material
    {
        get => _material;
        private set
        {
            if (value != 1 && value != 2)
            {
                throw new ArgumentException("Material must be 1(cemento) or 2(ladrillo)");
            }

            _material = value;
        }
    }
    
    public int Tamano
    {
        get => _tamano;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Tamano must be greater than 0");
            }

            _tamano = value;
        }
    }
}