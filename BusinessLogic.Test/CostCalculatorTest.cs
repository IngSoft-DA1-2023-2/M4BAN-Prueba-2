using BusinessLogic;
namespace BusinessLogic.Test;


[TestClass]
public class CostCalculatorTest
{
    [TestMethod]
    public void calculatorPrecioTest()
    {
        Calculator cal = new Calculator();
        cal.Precio=28;
        Assert.AreEqual(28,cal.Precio);
    }

    [TestMethod]
    [ExpectedException(typeof(Calculator))]
    public void EmptyCalculatorPrecioTest()
    {
        Calculator cal = new Calculator();
        cal.Precio = 0;
        Assert.Fail();
    }

   /* [TestMethod]
    public void calculatorBaldosasTest()
    {
        Calculator cal = new Calculator();
        string expected = "baldosa1";
        cal.Baldosa = "baldosa1";
        Assert.AreEqual(expected,cal.Baldosa);
        
    }*/
}




