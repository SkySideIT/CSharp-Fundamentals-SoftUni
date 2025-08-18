/*

Hey hello 2 4
10 hey 4 hello

*/

string[] firstArr = Console.ReadLine().Split();
string[] secondArr = Console.ReadLine().Split();
string[] result = {};

for (int i = 0; i < secondArr.Length; i++)
{
	for (int j = 0; j < firstArr.Length; j++)
	{
		if (firstArr[j] == secondArr[i])
		{
			Console.Write(firstArr[j] + " ");
        }
	}
}