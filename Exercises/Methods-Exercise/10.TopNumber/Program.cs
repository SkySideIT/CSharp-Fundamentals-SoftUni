



namespace _10.TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 0; i < range; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int num)
        {
            if (IsDivisibleBy8(num) && HasOneOddDigit(num))
            {
                return true;
            }
            return false;
        }

        private static bool HasOneOddDigit(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                num /= 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsDivisibleBy8(int num)
        {
            int sumByDigits = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sumByDigits += digit;
                num /= 10;
            }

            return sumByDigits % 8 == 0;
        }
    }
}
