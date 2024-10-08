// Mi primer Pull request

using System.Security.Cryptography;

namespace HolaMundo;
public class Calculadora
{
   public bool IsMultiplo3(int numero)
   {
      return numero % 3 == 0;
   }

   public bool IsMultiplo5(int numero)
   {
      return numero % 5 == 0;
   }

   public bool Is3and5(int numero)
   {
      return (IsMultiplo3(numero) && IsMultiplo5(numero));
   }

   public string Imprime(int numero)
   {
      var cadena = numero.ToString();
      if (IsMultiplo3(numero))
      {
         cadena = "Fizz";
      }
      if (IsMultiplo5(numero))
      {
         cadena = "Buzz";
      }
      if (Is3and5(numero))
      {
         cadena = 
         "FizzBuzz";
      }
      return cadena;
   }

}