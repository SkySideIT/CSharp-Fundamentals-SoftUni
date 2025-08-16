double balance = 0;

string input;
while ((input = Console.ReadLine()) != "Start")
{
    double coin = double.Parse(input);

	if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
	{
		balance += coin;
	}
	else
	{
        Console.WriteLine($"Cannot accept {coin}");
    }
}

double nutsPrice = 2;
double waterPrice = 0.7;
double crispsPrice = 1.5;
double sodaPrice = 0.8;
double cokePrice = 1;

string product;
while ((product = Console.ReadLine()) != "End")
{
    if (product == "Nuts")
    {
        if (balance >= nutsPrice)
        {
            Console.WriteLine("Purchased nuts");
            balance -= nutsPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Water")
    {
        if (balance >= waterPrice)
        {
            Console.WriteLine("Purchased water");
            balance -= waterPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Crisps")
    {
        if (balance >= crispsPrice)
        {
            Console.WriteLine("Purchased crisps");
            balance -= crispsPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Soda")
    {
        if (balance >= sodaPrice)
        {
            Console.WriteLine("Purchased soda");
            balance -= sodaPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Coke")
    {
        if (balance >= cokePrice)
        {
            Console.WriteLine("Purchased coke");
            balance -= cokePrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
}

Console.WriteLine($"Change: {balance:f2}");