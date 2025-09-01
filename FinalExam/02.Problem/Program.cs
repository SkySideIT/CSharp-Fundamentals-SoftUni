/*
3 
##>00|no|NO|!!!?<### 
##>123|yes|YES|!!!<## 
$$<111|noo|NOPE|<<>$$  

*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                string passwordPattern = @"(?<surround>.+)\>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^\<\>]{3})\<\k<surround>";

                MatchCollection passwordMatches = Regex.Matches(input, passwordPattern);

                if (Regex.IsMatch(input, passwordPattern))
                {
                    string encryptedPassword = null;
                    foreach (Match passwordMatch in passwordMatches)
                    {
                        encryptedPassword = passwordMatch.Groups["first"].Value + passwordMatch.Groups["second"].Value + passwordMatch.Groups["third"].Value + passwordMatch.Groups["fourth"].Value;
                    }

                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
