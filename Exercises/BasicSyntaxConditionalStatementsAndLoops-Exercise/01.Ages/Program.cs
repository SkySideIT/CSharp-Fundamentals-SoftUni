int years = int.Parse(Console.ReadLine());

if (years >= 0 && years < 3)
{
    Console.WriteLine("baby");
}
else if (years > 2 && years < 14)
{
    Console.WriteLine("child");
}
else if (years > 13 && years < 20)
{
    Console.WriteLine("teenager");
}
else if (years > 19 && years < 66)
{
    Console.WriteLine("adult");
}
else if(years > 65)
{
    Console.WriteLine("elder");
}