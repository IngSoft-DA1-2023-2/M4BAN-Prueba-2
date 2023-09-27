using BusinessLogic;
namespace BusinessLogic.Test;


[TestClass]
public class CostCalculatorTest
{
    [TestMethod]
    public void calculatorTest()
    {
        Calculator cal = new Calculator();
        cal.precio=28;
        Assert.AreEqual(28,cal.precio);
    }
}




