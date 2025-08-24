/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end

 */


namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapcity = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
             
                if (arguments[0] == "Add")
                {
                    wagons.Add(int.Parse(arguments[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagonSpaceLeft = maxCapcity - wagons[i];

                        if (int.Parse(arguments[0]) <= currentWagonSpaceLeft)
                        {
                            wagons[i] += int.Parse(arguments[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
