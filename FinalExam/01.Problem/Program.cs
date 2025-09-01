/*
*S0ftUni is the B3St Plac3** 
Change 2 o 
Includes best 
End is 
Uppercase 
FindIndex P 
Cut 3 7 
Done 

*/

using System;
using System.Linq;

namespace _01.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = null;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = arguments[0];

                switch (action)
                {
                    case "Change":
                        input = input.Replace(arguments[1], arguments[2]);
                        Console.WriteLine(input);
                        break;
                    case "Includes":
                        if (input.Contains(arguments[1]))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "End":
                        int lengthOfSubstring = arguments[1].Length;
                        string backLength = input.Substring(input.Length - lengthOfSubstring);
                        if (backLength == arguments[1] && backLength.Length == lengthOfSubstring)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Uppercase":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        int index = input.IndexOf(arguments[1]);
                        Console.WriteLine(index);
                        break;
                    case "Cut":
                        string chars = input.Substring(int.Parse(arguments[1]), int.Parse(arguments[2]));
                        input = input.Remove(int.Parse(arguments[1]), int.Parse(arguments[2]));
                        Console.WriteLine(chars);
                        break;
                }
            }
        }
    }
}
