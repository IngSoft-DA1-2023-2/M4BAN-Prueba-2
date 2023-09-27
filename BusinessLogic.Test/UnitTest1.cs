namespace BusinessLogic.Test;

[TestClass]
public class BaldosaTest
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
    
    [TestMethod]
    public void Baldosa_controlDeTipos_ShouldFail()
    {
        string tipo = "triangulo";
        string material = "ladrillo";
        
        var ex = Assert.ThrowsException<ArgumentException>(() =>
        {
            Baldosa unused = new Baldosa
            {
                Tipo = tipo,
                Material = material,
            };
        });
        // Assert
        Assert.AreEqual(ex?.Message, "El tipo de baldosa no es correcto");
    }
    
}