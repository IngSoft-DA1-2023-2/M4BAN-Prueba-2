namespace BusinessLogic.Test;

[TestClass]
public class CostCalculatorTest
{
    /*Una empresa de baldosas quiere programar un sistema para calcular los costos de sus trabajos.
     Las baldosas pueden ser cuadradas o circulares. Además, pueden ser de uno de los siguientes 
     materiales: Cemento ($5) o Ladrillo ($10). El precio de cada baldosa se calcula como área de la 
     baldosa * precio del metro cuadrado * precio del material.
     
     Modelar el problema usando TDD. El modelado debe tener una clase CostCalculator con un único 
     método el cual recibe dos parámetros: una lista de baldosas y el precio por metro cuadrado, y 
     devuelve el costo total.
     */
    [TestMethod]
    public void CalculateTotalCost_Valid()
    {
        //Arrange
        List<Valdosa> valdosas = new List<Valdosa>
        {
            new Valdosa(TipoValdosa."1", Material.Cemento, 4),
            new Valdosa(TipoValdosa."2", Material.Ladrillo, 2)
        };
        int precioMetroCuad = 5;
        
        //Act
        CostCalculator calc = new CostCalculator();
        int totalCost = calc.Calculator(valdosas, precioMetroCuad);

        //Assert
        Assert.AreEqual(70, totalCost);

    }
    
    
}