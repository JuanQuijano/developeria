Console.Clear();

var fahrenheit = 94;
var celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + Math.Round(celsius,1) + " Celsius.");
Console.WriteLine("The temperature is " + celsius.ToString("##.#") + " Celsius.");
Console.WriteLine("The temperature is " + decimal.Round(celsius,1) + " Celsius.");
