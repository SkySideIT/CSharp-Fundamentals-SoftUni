double peopleCount = double.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string dayOfWeek = Console.ReadLine();

double singlePersonPrice = 0;
double total = 0;

if (groupType == "Students")
{
	if (dayOfWeek == "Friday")
	{
        singlePersonPrice = 8.45;
    }
    else if (dayOfWeek == "Saturday")
    {
        singlePersonPrice = 9.80;
    }
    else if (dayOfWeek == "Sunday")
    {
        singlePersonPrice = 10.46;
    }

    double totalWithoutDiscount = singlePersonPrice * peopleCount;
    if (peopleCount >= 30)
    {
        total = totalWithoutDiscount * 0.85;
    }
}
else if (groupType == "Business")
{
    if (dayOfWeek == "Friday")
    {
        singlePersonPrice = 10.90;
    }
    else if (dayOfWeek == "Saturday")
    {
        singlePersonPrice = 15.60;
    }
    else if (dayOfWeek == "Sunday")
    {
        singlePersonPrice = 16;
    }

    double totalWithoutDiscount = singlePersonPrice * peopleCount;
    if (peopleCount >= 100)
    {
        total = totalWithoutDiscount - (singlePersonPrice * 10);
    }
}
else if (groupType == "Regular")
{
    if (dayOfWeek == "Friday")
    {
        singlePersonPrice = 15;
    }
    else if (dayOfWeek == "Saturday")
    {
        singlePersonPrice = 20;
    }
    else if (dayOfWeek == "Sunday")
    {
        singlePersonPrice = 22.50;
    }

    double totalWithoutDiscount = singlePersonPrice * peopleCount;
    if (peopleCount >= 10 && peopleCount <= 20)
    {
        total = totalWithoutDiscount * 0.95;
    }
    else
    {
        total = totalWithoutDiscount;
    }
}

Console.WriteLine($"Total price: {total:f2}");