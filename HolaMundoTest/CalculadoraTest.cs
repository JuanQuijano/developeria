// dotnet add HolaMundoTest\HolaMundoTest.csproj reference HolaMundo\HolaMundo.csproj

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
    [TestMethod]
    public void Resta_5_1_y_da_4()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();
        var numero1 = 5;
        var numero2 = 1;
        var resultadoEsperado = 4;

        // Act
        var resultado = calculadora.Resta(numero1, numero2);

        // Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]
    public void Multiplica_2_2_y_da_4()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();
        var numero1 = 2;
        var numero2 = 2;
        var resultadoEsperado = 4;

        // Act
        var resultado = calculadora.Multiplica(numero1, numero2);

        // Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
}