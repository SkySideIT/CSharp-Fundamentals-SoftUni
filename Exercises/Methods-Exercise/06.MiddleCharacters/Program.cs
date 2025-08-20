

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] middle = GetMiddle(str);
            for (int i = 0; i < middle.Length; i++)
            {
                Console.Write(middle[i]);
            }
        }

        private static char[] GetMiddle(string str)
        {
            char[] strNew = str.ToCharArray();
            char[] middle = new char[strNew.Length];
            if (str.Length % 2 == 0)
            {
                middle[0] = strNew[(strNew.Length / 2) - 1];
                middle[1] = strNew[strNew.Length / 2];
            }
            else
            {
                middle[0] = strNew[strNew.Length / 2];
            }
            return middle;
        }
    }
}
