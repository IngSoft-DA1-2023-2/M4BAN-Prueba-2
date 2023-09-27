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
    public void calculatorBaldosasTest()
    {
        Calculator cal = new Calculator();
        cal.Baldosa = "baldosa1";
        List<string> baldosas = new List<string>() { "baldosa1", "baldosa2", "baldosa3"};
        Assert.AreEqual(baldosas[0],cal.Baldosa);
    }

    [TestMethod]
    [ExpectedException(typeof(Calculator))]
    public void EmptyCalculatorPrecioTest()
    {
        Calculator cal = new Calculator();
        cal.Precio = 0;
        Assert.Fail();
    }
    

    [TestMethod]
    [ExpectedException(typeof(Calculator))]
    public void EmptyCalculatorBaldosaTest()
    {
        Calculator cal = new Calculator();
        string expected = "";
        cal.Baldosa = "";
        Assert.Fail();
    }
}




