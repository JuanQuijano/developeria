int[] schedule = { 800, 1200, 1600, 2000 };
var newGMTA = -6;

DisplayAdjustedTimes((int[])schedule.Clone(), newGMTA, 6);

void DisplayAdjustedTimes(int[] times, int newGMT, int currentGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }


    Console.Clear();
    for (var i = 0; i < times.Length; i++)
    {
        var newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
    
    newGMT = 50;
}

    Console.Clear();
    for (var i = 0; i < schedule.Length; i++)
    {
        Console.WriteLine($"{schedule[i]}");
    }

    Console.WriteLine(newGMTA);

