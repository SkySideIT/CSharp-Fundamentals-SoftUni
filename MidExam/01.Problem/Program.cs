namespace _01.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double incomeFromSingleSearch = double.Parse(Console.ReadLine());
            double numberOfUsers = double.Parse(Console.ReadLine());
            double totalIncome = 0;

            for (int i = 1; i <= numberOfUsers; i++)
            {
                double numberOfSearchesByUser = double.Parse(Console.ReadLine());
                double currentIncome = 0;
                
                if (numberOfSearchesByUser > 1 || numberOfSearchesByUser < 5)
                {
                    currentIncome = incomeFromSingleSearch * numberOfSearchesByUser;
                }

                if (numberOfSearchesByUser > 5)
                {
                    currentIncome = (incomeFromSingleSearch * numberOfSearchesByUser) * 2;
                }

                if (numberOfSearchesByUser == 1)
                {
                    continue;
                }

                if (i % 3 == 0)
                {
                    currentIncome = (incomeFromSingleSearch * numberOfSearchesByUser) * 3;
                    if (numberOfSearchesByUser > 5)
                    {
                        currentIncome *= 2;
                    }
                    if (numberOfSearchesByUser < 2)
                    {
                        continue;
                    }
                }

                totalIncome += currentIncome;
            }

            Console.WriteLine($"Total money earned: {totalIncome:f2}");
        }
    }
}
