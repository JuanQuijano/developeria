// Mi primer Pull request

using System.Security.Cryptography;

namespace HolaMundo;
public class Calculadora
{
    public int Suma(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    public int? Resta(int numero1, int? numero2)
    {
        return numero1-numero2;
    }

        public int? Division(int dividendo, int divisor)
    {
        int? resultado = null;
        if (divisor > 0)
        {resultado = dividendo/divisor;}

        return resultado;
    }


    /* public int Suma(int numero1, int numero2)
     {
         return numero1 + numero2;
     }
     public int Resta(int numero1, int numero2)
     {
         return numero1 - numero2;
     }
     public int Multiplica(int numero1, int numero2)
     {
         return numero1 * numero2;
     }*/

}