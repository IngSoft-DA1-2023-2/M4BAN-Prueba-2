namespace BusinessLogic;

public class CostCalculator
{
    //Una empresa de baldosas quiere programar un sistema para calcular los costos de sus trabajos. Las baldosas pueden ser cuadradas o circulares. Además, pueden ser de uno de los siguientes materiales: Cemento ($5) o Ladrillo ($10). El precio de cada baldosa se calcula como área de la baldosa * precio del metro cuadrado * precio del material.
    
    
    public int CalculateCost(int length, int width, int costPerSquareMeter)
    {
        return length * width * costPerSquareMeter;
    }
}