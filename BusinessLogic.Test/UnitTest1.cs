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
    
    [TestMethod]
    
    public void nuevaBaldosaInicilizacionAtributos()
    {
        string tipo = "circular";
        string material = "ladrillo";
        Baldosa baldosa = new Baldosa(tipo, material);
        
        Assert.AreEqual(tipo, baldosa.Tipo);
    }
    
}