/*
1 23 29 18 43 21 20
Add 5
Remove 5
Shift left 3
Shift left 1
End

 */


namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                if (arguments[0] == "Add")
                {
                    list.Add(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Insert")
                {
                    if (IsNotValidIndex(int.Parse(arguments[2]), list.Count))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    list.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Remove")
                {
                    if (IsNotValidIndex(int.Parse(arguments[1]), list.Count))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    list.RemoveAt(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Shift")
                {
                    Shift(list, arguments[1], int.Parse(arguments[2]));
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static bool IsNotValidIndex(int index, int count)
        {
            return index < 0 || index >= count;
        }

        private static void Shift(List<int> list, string direction, int count)
        {
            count %= list.Count;

            if (direction == "left")
            {
                List<int> shiftedPart = list.GetRange(0, count);
                list.RemoveRange(0, count);
                list.InsertRange(list.Count, shiftedPart);
            }
            else if (direction == "right")
            {
                List<int> shiftedPart = list.GetRange(list.Count - count, count);
                list.RemoveRange(list.Count - count, count);
                list.InsertRange(0, shiftedPart);
            }
        }
    }
}
