
namespace _04.Password_Validator
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool numberOfChars = NumberOfChars(input);
            bool onlyLettersAndDigits = OnlyLettersAndDigits(input);
            bool atLeast2Digits = AtLeast2Digits(input);

            if (!numberOfChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!onlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!atLeast2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (numberOfChars && onlyLettersAndDigits && atLeast2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool AtLeast2Digits(string input)
        {
            int digitsCount = input.Count(c => Char.IsDigit(c));
            if (digitsCount < 2)
            {
                return false;
            }
            return true;
        }

        static bool OnlyLettersAndDigits(string input)
        {
            if (input.All(Char.IsLetterOrDigit))
            {
                return true;
            }
            return false;
        }

        static bool NumberOfChars(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
