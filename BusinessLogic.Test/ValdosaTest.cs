namespace BusinessLogic.Test;

public class ValdosaTest
{
    [TestMethod]
    public void NewValdosaTest()
    {
        // Arrange
        
        //1 = circular
        //2 = cuadrada
        int tipo = 1;
        
        //5 = cemento
        //10 = ladrillo
        int material = 5;
        
        int tamano = 10; //radio o lado
        
        // Act
        Valdosa valdosa = new Valdosa(tipo, material, tamano);
        
        // Assert
        Assert.AreEqual(valdosa.Tipo, tipo);
        Assert.AreEqual(material, valdosa.Material);
        Assert.AreEqual(tamano, valdosa.Tamano);
    }
}