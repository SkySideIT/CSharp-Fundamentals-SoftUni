string[] numsArr = Console.ReadLine().Split();
int[] nums  = new int[numsArr.Length];
for (int i = 0; i < numsArr.Length; i++)
{
    nums[i] = int.Parse(numsArr[i]);
}
int result = int.Parse(Console.ReadLine());

for (int i = 0; i < nums.Length; i++)
{
	for (int j = i + 1; j < nums.Length; j++)
	{
		if (nums[i] + nums[j] == result)
		{
			Console.Write(nums[i] + " " + nums[j]);
            Console.WriteLine();
        }
	}
}