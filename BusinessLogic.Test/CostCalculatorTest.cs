namespace BusinessLogic.Test;

public class CostCalculatorTest
{
    [TestMethod]
    public void CalculateCost_ShouldSucceed()
    {
        CostCalculator costCalculator = new CostCalculator();
        List<Baldosa> baldosas = new List<Baldosa>();
        Baldosa baldosa = new Baldosa("circular", "ladrillo");
        baldosas.Add(baldosa);
        double cost = costCalculator.CalculateCost(baldosas);
        Assert.AreEqual(10, cost);
    }
}