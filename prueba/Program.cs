// Desafio Realización de un desafío para combinar valores de matriz de cadenas como cadenas y como enteros

using System.Runtime.InteropServices.Marshalling;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
var mensaje = "";
var total = 0.0;

foreach (var value in values)
{
    if (double.TryParse(value, out double resultado))
    { total += resultado; }
    else
    { mensaje += value; }
}

Console.Clear();
Console.WriteLine("Mensaje: " + mensaje);
Console.WriteLine("Total: " + total);



