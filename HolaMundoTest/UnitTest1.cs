namespace HolaMundo;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Suma_5_3_y_da_8()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 5;
        int numero2 = 3;
        int resultadoEsperado = 8;

        // Act
        int resultado = calculadora.Suma(numero1, numero2);

        // Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
}