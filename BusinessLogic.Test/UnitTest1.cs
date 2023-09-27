namespace BusinessLogic.Test;

[TestClass]
public class Baldosa
{
    [TestMethod]
    public void nuevaBaldosa()
    {
        Baldosa baldosa = new Baldosa();
        Assert.IsNotNull(baldosa);
    } 
    
}