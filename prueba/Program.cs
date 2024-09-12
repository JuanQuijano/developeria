using System.Text;

Console.OutputEncoding = Encoding.UTF8;


/*
Console.WriteLine("Hola mundo");
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);





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
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine(@"c:\source\repos");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine("----");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
Console.Write(@"c:\invoices");


// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
Console.WriteLine("----");


// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("Lo siguiente falla");
//Este falla
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("Hola" + " Pepe");*/

Console.Clear();
string greeting = "Hello";
string firstName = "Bob";

Console.WriteLine(greeting + " " + firstName + "!");

string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

Console.Clear();
int version = 11;
string updateText = "Update to Windows";
message = $"{updateText} {version.ToString()}!";
Console.WriteLine(message);

Console.Clear();
string projectName = "First-Project";
string? path = $@"C:\Output\{projectName}\Data";
path = null;
Console.WriteLine(path);