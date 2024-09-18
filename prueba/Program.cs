Console.Clear();
for (int i = 0; i <= 100; i++)
{
var resultado = i + ((i % 3 == 0) && (i % 5 == 0) ? "- FizzBuzz" :
                (i % 3 == 0)?"- Fizz": 
                (i % 5 == 0)?"- Buzz":"");

Console.WriteLine(i+ resultado);
}