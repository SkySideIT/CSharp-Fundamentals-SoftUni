int number = int.Parse(Console.ReadLine());

int numberCopy = number;
int factSum = 0;

while (numberCopy > 0)
{
    int digit = numberCopy % 10;
    numberCopy /= 10;

    int fact = 1;
    for (int i = 1; i <= digit; i++)
    {
        fact *= i;
    }

    factSum += fact;
}

bool isStrong = factSum == number;

Console.WriteLine(isStrong ? "yes" : "no");