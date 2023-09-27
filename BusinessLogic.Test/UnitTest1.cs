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
    
    [TestMethod]
    public void Baldosa_controlDeMaterial_ShouldFail()
    {
        string tipo = "circular";
        string material = "papel";
        
        var ex = Assert.ThrowsException<ArgumentException>(() =>
        {
            Baldosa unused = new Baldosa
            {
                Tipo = tipo,
                Material = material,
            };
        });
        // Assert
        Assert.AreEqual(ex?.Message, "El material de baldosa no es correcto");
    }
    
    [TestMethod]
    public void Baldosa_setMaterial_ShouldSucceed()
    {
        string tipo = "circular";
        string material = "ladrillo";
        
        Baldosa unused = new Baldosa
        {
            Tipo = tipo,
            Material = material,
        };
        
        Assert.AreEqual(material, unused.Material);
    }
    
    
    [TestMethod]
    public void precio_shouldSucceed()
    {
    string tipo = "circular";
    string material = "ladrillo";
        
    Baldosa unused = new Baldosa
    {
        Tipo = tipo,
        Material = material,
    };
        
    Assert.AreEqual(10, unused.PrecioMetro2);
}
    
    [TestMethod]
    public void preciocemento_shouldSucceed()
    {
        string tipo = "circular";
        string material = "ladrillo";
        
        Baldosa unused = new Baldosa
        {
            Tipo = tipo,
            Material = material,
        };
        
        Assert.AreEqual(5, unused.PrecioMetro2);
    }
    
    [TestMethod]
    public void agregarListaBaldosa_shouldSucceed()
    {
        string tipo = "circular";
        string material = "ladrillo";
        
        Baldosa unused = new Baldosa
        {
            Tipo = tipo,
            Material = material,
        };
        
        List<Baldosa> listaBaldosas = new List<Baldosa>();
        listaBaldosas.Add(unused);
        
        
    }
    
}