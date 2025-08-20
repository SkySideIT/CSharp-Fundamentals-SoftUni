
namespace _02.Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = GetVolewsCount(input);
            Console.WriteLine(vowelsCount);
        }

        static int GetVolewsCount(string input)
        {
            int vowelsCount = 0;
            input = input.ToLower();

            foreach (char c in input)
            {
                if (c == 'e' || c == 'o' || c == 'i' || c == 'u' || c == 'a')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
