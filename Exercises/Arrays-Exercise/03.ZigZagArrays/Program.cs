int lines = int.Parse(Console.ReadLine());
int[] firstNums = new int[lines];
int[] secondNums = new int[lines];

for (int i = 0; i < lines; i++)
{
    int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
	if (i == 0 || i % 2 == 0)
	{
		firstNums[i] = inputs[0];
		secondNums[i] = inputs[1];
	}
	else
	{
		firstNums[i] = inputs[1];
		secondNums[i] = inputs[0];
	}
}

for (int i = 0; i < firstNums.Length; i++)
{
	Console.Write(firstNums[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < secondNums.Length; i++)
{
    Console.Write(secondNums[i] + " ");
}