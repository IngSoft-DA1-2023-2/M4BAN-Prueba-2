namespace BusinessLogic.Test;

[TestClass]
public class CostCalculatorTest
{
    [TestMethod]
    public void Crear_Objeto_CostCalculator()
    {
        // Arrange
        var costCalculator = new CostCalculator();

        // Act

        // Assert
        Assert.IsNotNull(costCalculator);
    }
}