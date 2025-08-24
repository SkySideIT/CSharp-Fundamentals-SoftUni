namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                int element = int.Parse(arguments[1]);

                if (arguments[0] == "Insert")
                {
                    int index = int.Parse(arguments[2]);
                    list.Insert(index, element);
                }
                else if (arguments[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list.Remove(element);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
