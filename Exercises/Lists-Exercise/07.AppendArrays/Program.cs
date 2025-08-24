/*
1 2 3 |4 5 6 | 7 8
 
 */

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                string[] updatedArray = array[i]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                result.AddRange(updatedArray);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
