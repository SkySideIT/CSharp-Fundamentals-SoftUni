/*
1 2 2 4 2 2 2 9
4 2

 */

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int number = bomb[0];
            int power = bomb[1];

            while (list.Contains(number))
            {
                int index = list.IndexOf(number);

                int leftBoom = Math.Max(0, index - power);
                int rightBoom = Math.Min(list.Count - 1, index + power);
                int range = rightBoom - leftBoom + 1;

                list.RemoveRange(leftBoom, range);
            }

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
        }
    }
}
