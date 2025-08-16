int orders = int.Parse(Console.ReadLine());

double currentTotal = 0;
double total = 0;
for (int i = 0; i < orders; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    currentTotal = pricePerCapsule * days * capsulesCount;
    if (orders == 1)
    {
        total = currentTotal;
    }
    else
    {
        total += currentTotal;
    }
    Console.WriteLine($"The price for the coffee is: ${currentTotal:f2}");
}

Console.WriteLine($"Total: ${total:f2}");