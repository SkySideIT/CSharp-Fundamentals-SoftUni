

namespace _05.AddandSubtract
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = GetSum(num1, num2);
            int substract = Substract(sum, num3);
            Console.WriteLine(substract);
        }

        private static int Substract(int sum, int num3)
        {
            int substract = sum - num3;
            return substract;
        }

        private static int GetSum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
