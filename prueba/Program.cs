Random random = new Random();

var discountPercentage = 10;
var continua =  true;

while (continua)
{
    var daysUntilExpiration = random.Next(12);


    Console.Clear();

    Console.WriteLine("Numero de dias para que expire: " + daysUntilExpiration);
    if (daysUntilExpiration > 5)
    {
        Console.WriteLine("Tu suscripción está a punto de expirar. Renuevela ahora!");
    }
    else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
    {
        Console.WriteLine("Tu suscripción está expira en " + daysUntilExpiration + " dias.");
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine("Tu suscripción expira hoy \n Renueva y ahorrate un " + discountPercentage + "%");
    }
    else
    {
        Console.WriteLine("Tu suscripción ha expirado");
    }


    switch (daysUntilExpiration)
    {
        case int n when (n > 5):
            Console.WriteLine("Tu suscripción está a punto de expirar. Renuevela ahora!");
            break;
        case int n when (n <= 5 && n > 3):
            Console.WriteLine("Tu suscripción está expira en " + daysUntilExpiration + " dias.");
            break;
        case int n when (n == 1):
            Console.WriteLine("Tu suscripción expira hoy \n Renueva y ahorrate un " + discountPercentage + "%");
            break;
        default:
            Console.WriteLine("Tu suscripción ha expirado");
            break;
    }

    var tecla = Console.ReadKey();
    if(tecla.KeyChar == 'x')
    {continua = false;}

}
