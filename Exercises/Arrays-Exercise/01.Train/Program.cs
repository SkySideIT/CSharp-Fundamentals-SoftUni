int wagons = int.Parse(Console.ReadLine());
int sum = 0;
int[] peopleArr = new int[wagons];

for (int i = 0; i < wagons; i++)
{
    int people = int.Parse(Console.ReadLine());
    peopleArr[i] = people;
    sum += people;
}

for (int i = 0; i < peopleArr.Length; i++)
{
    Console.Write(peopleArr[i] + " ");
}
Console.WriteLine();
Console.WriteLine(sum);