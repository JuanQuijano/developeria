/*Console.WriteLine("Hola mundo");
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);*/



using System.Reflection.Metadata;

var firstName ="Blob";
var messsagesNumber =1;
var celsius = 27.5;

firstName = "Bob";
Console.Write("Hello, ");
Console.Write(firstName);
Console.Write("!");
Console.Write("You have ");
Console.Write(messsagesNumber);
Console.Write(" messages in your inbox. ");
Console.Write("The temperature is ");
Console.Write(celsius);
Console.WriteLine(" celsius.");


Console.Write("Hello, " +  firstName + "! You have " + messsagesNumber + " messages in your inbox. The temperature is " + celsius + " celsius.");
