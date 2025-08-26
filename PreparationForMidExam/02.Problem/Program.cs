/*
1 4 5 19
Add 1
Remove 4
Finish

*/


namespace _02.Problem
{
    internal class Program
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                int value = int.Parse(arguments[1]);

                switch (command)
                {
                    case "Add":
                        sequence.Add(value);
                        break;
                    case "Remove":
                        sequence.Remove(value);
                        break;
                    case "Replace":
                        int index = sequence.IndexOf(value);
                        sequence.Insert(index, int.Parse(arguments[2]));
                        sequence.Remove(value);
                        break;
                    case "Collapse":
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            if (sequence[i] < value)
                            {
                                sequence.Remove(sequence[i]);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }   
    }
}
