var vidaDelHeroe = 10;
var vidaDelMonstruo = 10;
var dados = new Random();
var tirada = 0;
var atacante = true;

Console.Clear();

do
{
    Console.WriteLine($"Ataca el {atacante}");

    tirada = dados.Next(1, 11);
    Console.Write(" -> saca un " + tirada);

    vidaDelMonstruo -= tirada;
    Console.WriteLine($" -> le quedan {vidaDelMonstruo} puntos de vida al monstruo");

    if (vidaDelMonstruo >= 0)
    {
        Console.WriteLine("Ataca el monstruo");
        tirada = dados.Next(1, 11);
        Console.Write(" -> saca un " + tirada);

        vidaDelHeroe -= tirada;
        Console.WriteLine($" -> le quedan {vidaDelHeroe} puntos de vida al heroe");
        if (vidaDelHeroe <= 0)
        {
            Console.WriteLine("Ha muerto el heroe");
        }
    }
    else
    { Console.WriteLine("El monstruo ha muerto"); }

    Console.ReadKey();

} while (vidaDelHeroe > 0 && vidaDelMonstruo > 0); 

Console.WriteLine("El combate ha finalizado");
