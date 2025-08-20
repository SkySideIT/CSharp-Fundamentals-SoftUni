

namespace _03.Characters_in_Range
{
    internal class Program
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            if (a > b)
            {
                char temp = a;
                b = a;
                a = temp;
            }

            PrintBetween(a, b);
        }

        static void PrintBetween(char a, char b)
        {
            for (int i = a + 1; i < b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
