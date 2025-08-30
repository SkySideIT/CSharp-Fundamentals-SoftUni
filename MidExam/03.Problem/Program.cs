using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sentence = Console.ReadLine()
                .Split()
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Delete":
                        Delete(int.Parse(arguments[1]), sentence);
                        break;
                    case "Swap":
                        Swap(arguments[1], arguments[2], sentence);
                        break;
                    case "Put":
                        Put(arguments[1], int.Parse(arguments[2]), sentence);
                        break;
                    case "Sort":
                        Sort(sentence);
                        break;
                    case "Replace":
                        Replace(arguments[1], arguments[2], sentence);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", sentence));
        }

        private static void Delete(int index, List<string> sentence)
        {
            if (index >= 0 && index + 1 < sentence.Count)
            {
                sentence.RemoveAt(index + 1);
            }
        }

        private static void Swap(string word1, string word2, List<string> sentence)
        {
            if (sentence.Contains(word1) && sentence.Contains(word2))
            {
                string temp;
                temp = sentence[sentence.IndexOf(word1)];
                sentence[sentence.IndexOf(word1)] = sentence[sentence.IndexOf(word2)];
                sentence[sentence.IndexOf(word2)] = temp;
            }
        }

        private static void Put(string word, int index, List<string> sentence)
        {
            if (index > 0 && index <= sentence.Count + 1)
            {
                sentence.Insert(index - 1, word);
            }
        }

        private static void Sort(List<string> sentence)
        {
            sentence.Sort();
            sentence.Reverse();
        }

        private static void Replace(string word1, string word2, List<string> sentence)
        {
            int index = sentence.IndexOf(word2);
            if (index != -1)
            {
                sentence[index] = word1;
            }
        }
    }
}
