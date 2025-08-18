/*

10 5 5 99 3 4 2 5 1 1 4 

*/

using System;
using System.Linq;

/*
string numbersStr = Console.ReadLine();
string[] numbersArrStr = numbersStr.Split();
var numbersSelect = numbersArrStr.Select(int.Parse);
int[] numbers = numbersSelect.ToArray();
*/

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int index = -1;

for (int i = 0; i < numbers.Length; i++)
{
    int sumLeft = 0;
    int sumRight = 0;

    for (int j = i - 1; j >= 0; j--)
    {
        sumLeft += numbers[j];
    }

    for (int k = i + 1; k < numbers.Length; k++)
    {
        sumRight += numbers[k];
    }

    if (sumLeft == sumRight)
    {
        index = i;
        break;
    }
}

if (index != -1)
{
    Console.WriteLine(index);
}
else
{
    Console.WriteLine("no");
}