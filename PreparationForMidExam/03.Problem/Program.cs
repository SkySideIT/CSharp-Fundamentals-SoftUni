/*
HuaweiP20, XiaomiNote
Remove - Samsung
Bonus phone - XiaomiNote:Iphone5
End
 
 */


namespace _03.Problem
{
    internal class Program
    {
        static void Main()
        {
            List<string> phones = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Add":
                        if (phones.Contains(arguments[2]))
                        {
                            continue;
                        }
                        else
                        {
                            phones.Add(arguments[2]);
                        }
                        break;
                    case "Remove":
                        if (phones.Contains(arguments[2]))
                        {
                            phones.Remove(arguments[2]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Bonus":
                        string twoPhones = arguments[3];
                        string[] splited = twoPhones.Split(":");
                        if (phones.Contains(splited[0]))
                        {
                            int index = phones.IndexOf(arguments[3]);
                            phones.Insert(phones.IndexOf(splited[0]) + 1, splited[1]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Last":
                        if (phones.Contains(arguments[2]))
                        {
                            phones.Remove(arguments[2]);
                            phones.Add(arguments[2]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
