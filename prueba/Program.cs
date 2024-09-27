Console.Clear();
int[] numeros = {1,2,3,4,5};



void PrintArrayDeNumeros()
{
    foreach (var numero in numeros)
    {
        Console.Write($"{numero} ");
    }
    Console.WriteLine();
}



Console.WriteLine("Contents of Array:");
PrintArrayDeNumeros();

