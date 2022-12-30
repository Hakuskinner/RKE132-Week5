Console.WriteLine("What is the temperature?");
int temp = Int32.Parse(Console.ReadLine());
if (temp >= 30)
{
    Console.WriteLine("Its way too hot!");
}
else if (temp < 30 && temp >= 25)
{
    Console.WriteLine("Its hot!");
}
else if (temp < 25 && temp >= 20)
{
    Console.WriteLine("Its little hot!");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Its Estonian summer!");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Its okei!");
}
else if (temp < 10 && temp >= 0)
{
    Console.WriteLine("Its little cold");
}
else if (temp < 0)
{
    Console.WriteLine("Its cold!");
}
