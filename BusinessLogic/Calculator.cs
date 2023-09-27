namespace BusinessLogic;


public class Calculator
{
    private int _precio;
    private string _baldosa;

    public int Precio
    {
        get=> _precio;
        set
        {
            try
            {
                if (value == 0)
                {
                    throw new CalculatorException("no puede ser cero el precio");
                }

                _precio = value;
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public string Baldosa
    {
        get=>_baldosa;
        set
        {
            try
            {
                if (value == "")
                {
                    throw new CalculatorException("la baldosa debe existir");
                }

                _baldosa = value;
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e);
                throw;
            }  
        }
    }
}