

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString;
            while ((numberAsString = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(numberAsString));
            }
        }

        static bool IsPalindrome(string palindromeString)
        {
            string reversedString = Reverse(palindromeString);
            return palindromeString == reversedString;
        }

        static string Reverse(string palindromeString)
        {
            char[] ch = palindromeString.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }
    }
}
