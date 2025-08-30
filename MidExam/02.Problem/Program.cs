using System;
using System.ComponentModel;
using System.Linq;

namespace _02.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponName = Console.ReadLine()
                .Split("|")
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Add":
                        Add(arguments[1], int.Parse(arguments[2]), weaponName);
                        break;
                    case "Remove":
                        Remove(int.Parse(arguments[1]), weaponName);
                        break;
                    case "Check":
                        Check(arguments[1], weaponName);
                        break;
                }
            }

            Console.WriteLine($"You crafted {string.Join("", weaponName)}!");
        }

        static void Add(string particle, int index, List<string> weaponName)
        {
            if (index >= 0 && index < weaponName.Count)
            {
                weaponName.Insert(index, particle);
            }
            else
            {
                return;
            }
        }

        static void Remove(int index, List<string> weaponName)
        {
            if (index >= 0 && index < weaponName.Count)
            {
                weaponName.RemoveAt(index);
            }
            else
            {
                return;
            }
        }

        static void Check(string evenOrOdd, List<string> weaponName)
        {
            List<string> check = new List<string>();

            if (evenOrOdd == "Even")
            {
                for (int i = 0; i < weaponName.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        check.Add(weaponName[i]);
                    }
                }
            }
            else if (evenOrOdd == "Odd")
            {
                for (int i = 0; i < weaponName.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        check.Add(weaponName[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", check));
        }
    }
}
