using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

string input = "Pad this";
string input2 = "Pad two of two";
 Console.WriteLine(input.PadLeft(20,'-'));
Console.WriteLine(input2.PadLeft(20,'-'));

