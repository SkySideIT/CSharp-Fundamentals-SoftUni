/*
5
Tom is going!
Annie is going!
Tom is going!
Garry is going!
Jerry is going!

 */

using System.Xml.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();
                string[] arguments = input.Split();
                if (arguments[2] == "going!")
                {
                    if (guests.Contains(arguments[0]))
                    {
                        Console.WriteLine($"{arguments[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(arguments[0]);
                    }
                }
                else if (arguments[2] == "not")
                {
                    if (guests.Contains(arguments[0]))
                    {
                        guests.Remove(arguments[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{arguments[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
