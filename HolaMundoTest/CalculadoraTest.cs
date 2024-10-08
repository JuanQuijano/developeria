// dotnet add HolaMundoTest\HolaMundoTest.csproj reference HolaMundo\HolaMundo.csproj

namespace HolaMundo;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void Le_mando_3_y_responde_true()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 3;
        var resultadoEsperado = true;

        var resultado = calculadora.IsMultiplo3(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]
    public void Le_mando_2_y_responde_false()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 2;
        var resultadoEsperado = false;

        var resultado = calculadora.IsMultiplo3(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Le_mando_5_y_responde_true()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 5;
        var resultadoEsperado = true;

        var resultado = calculadora.IsMultiplo5(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }
        [TestMethod]
    public void Le_mando_4_y_responde_false()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 4;
        var resultadoEsperado = false;

        var resultado = calculadora.IsMultiplo5(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

     [TestMethod]
    public void Le_mando_7_y_responde_false()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 7;
        var resultadoEsperado = false;

        var resultado = calculadora.Is3and5(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]
    public void Le_mando_15_y_responde_true()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 15;
        var resultadoEsperado = true;

        var resultado = calculadora.Is3and5(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

        [TestMethod]
    public void Le_mando_3_y_responde_Fizz()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 3;
        var resultadoEsperado = "Fizz";

        var resultado = calculadora.Imprime(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

            [TestMethod]
    public void Le_mando_5_y_responde_Buzz()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 5;
        var resultadoEsperado = "Buzz";

        var resultado = calculadora.Imprime(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }
    
            [TestMethod]
    public void Le_mando_1_y_responde_1()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 1;
        var resultadoEsperado = "1";

        var resultado = calculadora.Imprime(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }
                [TestMethod]
    public void Le_mando_15_y_responde_FizzBuzz()
    {
        Calculadora calculadora = new Calculadora();
        var numero = 15;
        var resultadoEsperado = "FizzBuzz";

        var resultado = calculadora.Imprime(numero);

        Assert.AreEqual(resultadoEsperado, resultado);
    }
}
