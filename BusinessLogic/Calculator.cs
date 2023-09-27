namespace BusinessLogic;


public class Calculator
{
    private int _precio;

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
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
    public string Baldosa { get; set; }
}