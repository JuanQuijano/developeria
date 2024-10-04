// dotnet add HolaMundoTest\HolaMundoTest.csproj reference HolaMundo\HolaMundo.csproj

namespace HolaMundo;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void Suma_5_3_y_da_8()
    {
        Calculadora calculadora = new Calculadora();
        var numero1 = 5;
        var numero2 = 3;
        var resultadoEsperado = 8;

        var resultado = calculadora.Suma(numero1, numero2);

        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]
    public void Suma_2_2_y_da_4()
    {
        Calculadora calculadora = new Calculadora();
        var numero1 = 2;
        var numero2 = 2;
        var resultadoEsperado = 4;

        var resultado = calculadora.Suma(numero1, numero2);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Suma_menos2_menos2_y_da_menos4()
    {
        Calculadora calculadora = new Calculadora();
        var numero1 = 2;
        var numero2 = 2;
        var resultadoEsperado = 4;

        var resultado = calculadora.Suma(numero1, numero2);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Resta_3_menos_2_y_da_1()
    {
        Calculadora calculadora = new Calculadora();
        var numero1 = 3;
        var numero2 = 2;
        var resultadoEsperado = 1;

        var resultado = calculadora.Resta(numero1, numero2);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Resta_5_menos_2_y_da_3()
    {
        Calculadora calculadora = new Calculadora();
        var numero1 = 5;
        var numero2 = 2;
        var resultadoEsperado = 3;

        var resultado = calculadora.Resta(numero1, numero2);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Resta_menos5_menos_mas2_y_da_menos3()
    {
        Calculadora calculadora = new Calculadora();
        var numero1 = -5;
        var numero2 = 2;
        var resultadoEsperado = -7;

        var resultado = calculadora.Resta(numero1, numero2);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Divide_4_entre_2_y_da_2()
    {
        Calculadora calculadora = new Calculadora();
        var dividendo = 4;
        var divisor = 2;
        var resultadoEsperado = 2;

        var resultado = calculadora.Division(dividendo, divisor);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Divide_4_entre_0_y_da_null()
    {
        Calculadora calculadora = new Calculadora();
        var dividendo = 4;
        var divisor = 0;
        int? resultadoEsperado = null;

        var resultado = calculadora.Division(dividendo, divisor);

        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Suma2_2_menos_division_por_cero_me_da_null()
    {
        Calculadora calculadora = new Calculadora();
        var sumando1 = 2;
        var sumando2 = 2;
        var dividendo = 4;
        var divisor = 0;
        int? resultadoEsperado = null;
        
        var suma = calculadora.Suma(sumando1, sumando2);
        var division = calculadora.Division(dividendo, divisor);
        var resultado = calculadora.Resta(suma, division);

        Assert.AreEqual(resultadoEsperado, resultado);
    }


















    /*public void Suma_5_3_y_da_8()
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
    }*/

    /* [TestMethod]
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
     }*/
}