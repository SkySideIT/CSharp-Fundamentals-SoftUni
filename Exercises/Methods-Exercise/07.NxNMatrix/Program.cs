
namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            GetMatrix(number);
        }

        static void GetMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
