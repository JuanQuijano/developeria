Console.Clear();

Random dice = new Random();

/*int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Solución viendo solo total
Console.WriteLine($"Dice roll: {dice.Next(3,19)}");*/

// Solución con las tres tiradas

var total = 0;
int[] tirada = new int[3];

Console.Write("Dice roll:");
for (int i = 0; i < 3; i++)
{
    tirada[i] = dice.Next(1, 7);
    Console.Write($" {tirada[i]} {(i<2 ? "+" : "")}");
    total = total + tirada[i];
}

//Console.WriteLine('a' >= 'c');

if ((tirada[0] == tirada[1]) || (tirada[1] == tirada[2]) || (tirada[0] == tirada[2]))
{
    Console.WriteLine("\nYou rolled doubles! +2 bonus to total!");
    total += 2;
}
if ((tirada[0] == tirada[1]) && (tirada[1]== tirada[2])) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 4;
}


Console.WriteLine($"Total: {total}");

if (total > 10)
    Console.WriteLine("You win!");
else
    Console.WriteLine("Sorry, you lose.");