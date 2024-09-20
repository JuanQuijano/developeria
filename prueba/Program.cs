string pangram = "The quick brown fox jumps over the lazy dog";
string[] resultado = pangram.Split(" ");
//string[] reverse = new string[resultado.Length];
string final = string.Empty;


for (int i = 0; i < resultado.Length; i++)
{
    /*string palabra = resultado[i];
    string palabraInvertida = string.Join("", palabra.ToCharArray().Reverse());
    reverse[i] = palabraInvertida;*/
    final += string.Join("", resultado[i].ToCharArray().Reverse()) + " ";

}

Console.WriteLine(final);
