namespace BusinessLogic.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestCalculator()
    {
        //arrange
        var calculator = new CostCalculator();
        var cost = calculator.CalculateCost(10, 10, 800);
        
        //act
        var exception = Assert.ThrowsException<ArgumentException>(() => calculator.CalculateCost(10, 10, 800)); 
        
        //assert
        Assert.AreEqual(80000, cost);   
        
    }
}