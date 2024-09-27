using System.Runtime.CompilerServices;

var ip = "192.a.74.13";
var numbers = ip.Split('.');

bool ValidateLength()
{
    return numbers.Length == 4;
}
bool ValidateIp()
{
    bool ValidateZeroes(string number)
    {
        return (number.Length > 1 && number[0] == '0');
    }
    bool ValidateRange(string number)
    {
        return (int.Parse(number) < 0 || int.Parse(number) > 255);
    }

    foreach (var number in numbers)
    {
        if (ValidateZeroes(number) || ValidateRange(number))
        {
            return false;
        }
    }
    return true;
}


Console.Clear();
if (ValidateLength() && ValidateIp())
{
    Console.WriteLine($"{ip} ip is a VALID IPv4 address");
}
else
{
    Console.WriteLine($"{ip} ip is an INVALID IPv4 address");
}