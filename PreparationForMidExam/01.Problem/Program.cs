/*
78
8
16000

 */

namespace _01.Problem
{
    internal class Program
    {
        static void Main()
        {
            double biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            double countWorkers = int.Parse(Console.ReadLine());
            double rivalBiscuits = int.Parse(Console.ReadLine());

            double total = 0;
            double totalPerDay = countWorkers * biscuitsPerDayPerWorker;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    double everyThirdDay = Math.Floor(totalPerDay * 0.75);
                    total += everyThirdDay;
                }
                else
                {
                    total += countWorkers * biscuitsPerDayPerWorker;
                }
            }

            Console.WriteLine($"You have produced {total} biscuits for the past month.");

            if (total > rivalBiscuits)
            {
                double difference = total - rivalBiscuits;
                double percentMore = (difference / rivalBiscuits) * 100;
                Console.WriteLine($"You produce {percentMore:f2} percent more biscuits.");
            }
            else
            {
                double difference = rivalBiscuits - total;
                double percentLess = (difference / rivalBiscuits) * 100;
                Console.WriteLine($"You produce {percentLess:f2} percent less biscuits.");
            }
        }
    }
}
