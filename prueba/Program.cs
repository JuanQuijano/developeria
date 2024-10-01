using System.Runtime.InteropServices;

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

for (int i = 0; i < corporate.GetLength(0); i++)
{
    Console.WriteLine(CreateEmail(i, true));
}

for (int i = 0; i < external.GetLength(0); i++)
{
    Console.WriteLine(CreateEmail(i, false));
}

string CreateEmail(int indice, bool IsInternal)
{
    var internalDomain = "contoso.com";
    var externalDomain = "hayworth.com";
    var email = string.Empty;


    if (IsInternal)
    {
        var nombre = corporate[indice, 0].Substring(0, 2);
        var apellido = corporate[indice, 1];
        email = nombre + apellido + "@" + internalDomain;
    }
    else
    {
        var nombre = external[indice, 0].Substring(0, 2);
        var apellido = external[indice, 1];
        email = nombre + apellido + "@" + externalDomain;
    };

    return email.ToLower();
}