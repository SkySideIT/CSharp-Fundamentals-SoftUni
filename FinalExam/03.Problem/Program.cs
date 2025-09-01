/*
Enroll Stefan 
Enroll Peter 
Enroll Stefan 
Learn Stefan ItShouldWork 
Learn John ItShouldNotWork 
Unlearn George Dispel 
Unlearn Stefan ItShouldWork 
End


Enroll Stefan 
Learn Stefan ItShouldWork 
Learn Stefan ItShouldWork 
Unlearn Stefan NotFound 
End 

*/

using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _03.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new();

            string command = null;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                switch (action)
                {
                    case "Enroll":
                        Enroll(arguments[1], heroes);
                        break;
                    case "Learn":
                        Learn(arguments[1], arguments[2], heroes);
                        break;
                    case "Unlearn":
                        Unlearn(arguments[1], arguments[2], heroes);
                        break;
                }
            }

            Console.WriteLine("Heroes:");
            foreach (Hero hero in heroes.Values)
            {
                Console.WriteLine($"== {hero.Name}: {string.Join(", ", hero.Spells)}");
            }

        }

        public static void Unlearn(string name, string spell, Dictionary<string, Hero> heroes)
        {
            if (!heroes.ContainsKey(name))
            {
                Console.WriteLine($"{name} doesn't exist.");
                return;
            }

            Hero hero = heroes[name];

            if (hero.Spells.Contains(spell))
            {
                hero.Spells.Remove(spell);
            }
            else
            {
                Console.WriteLine($"{hero.Name} doesn't know {spell}.");
            }
        }

        public static void Learn(string name, string spell, Dictionary<string, Hero> heroes)
        {
            if (!heroes.ContainsKey(name))
            {
                Console.WriteLine($"{name} doesn't exist.");
                return;
            }

            Hero hero = heroes[name];

            if (!hero.Spells.Contains(spell))
            {
                hero.Spells.Add(spell);
            }
            else
            {
                Console.WriteLine($"{hero.Name} has already learnt {spell}.");
            }
        }

        public static void Enroll(string name, Dictionary<string, Hero> heroes)
        {
            if (!heroes.ContainsKey(name))
            {
                Hero hero = new(name, null);
                heroes.Add(name, hero);
            }
            else
            {
                Console.WriteLine($"{name} is already enrolled.");
            }
        }
    }
    
    class Hero
    {
        public Hero(string name, List<string> spells)
        {
            Name = name;
            Spells = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Spells { get; set; }
    }
}
