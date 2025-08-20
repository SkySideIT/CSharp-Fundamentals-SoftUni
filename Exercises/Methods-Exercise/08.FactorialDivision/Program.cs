
namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            double factNum1 = GetFactorial(num1);
            double factNum2 = GetFactorial(num2);
            Console.WriteLine($"{(factNum1 / factNum2):f2}");
        }

        private static double GetFactorial(double num1)
        {
            double fact = 1;
            for (int i = 1; i <= num1; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
