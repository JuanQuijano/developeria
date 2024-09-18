var vidaDelHeroe = 10;
var vidaDelMonstruo = 10;
var dados = new Random();
var tirada = 0;
var isHero = true;

Console.Clear();

do
{
    tirada = dados.Next(1, 11);
    if (isHero)
    {
        vidaDelMonstruo -= tirada;
        Console.WriteLine($"El monstruo ha recibido {tirada} puntos de daño. Y le quedan {vidaDelMonstruo} puntos de vida");
    }
    else
    {
        vidaDelHeroe -= tirada;
        Console.WriteLine($"El heroe ha recibido {tirada} puntos de daño. Y le quedan {vidaDelHeroe} puntos de vida");
    }

    isHero = !isHero;   

} while (vidaDelHeroe > 0 && vidaDelMonstruo > 0);

Console.WriteLine($"El combate ha finalizado, ha ganado el {(vidaDelHeroe > 0?"Heroe":"Monstruo")}");
