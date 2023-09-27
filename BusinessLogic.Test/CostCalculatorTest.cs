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

    [TestMethod]
    public void Calcular_Costo_Total()
    {
        // Arrange
        var costCalculator = new CostCalculator();
        var baldosa1 = new Baldosa("Cuadrado", 2, "Cemento");
        var baldosa2 = new Baldosa("Circulo", 3, "Cemento");
        var listaBaldosas = new List<Baldosa>
        {
            baldosa1,
            baldosa2
        };
        var precioMetroCuadrado = 5;
        var expected = 100 + (Math.PI * 3 * 3 * 5);
        // Act
        var actual = costCalculator.CalculateTotalCost(listaBaldosas, precioMetroCuadrado);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}