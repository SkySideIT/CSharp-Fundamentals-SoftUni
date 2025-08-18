/*
  
3
0 1
0 right 1
2 right 1
end

*/

using System;
using System.Linq;

int fieldLength = int.Parse(Console.ReadLine());
int[] field = new int[fieldLength];

int[] bugIndexes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < bugIndexes.Length; i++)
{
    int currentIndex = bugIndexes[i];
    if (currentIndex >= 0 && currentIndex < field.Length)
    {
        field[currentIndex] = 1;
    }
}

string command;
while ((command = Console.ReadLine()) != "end")
{
    //command = "0 right 1"
    string[] arguments = command.Split();
    // [ "0", "right", "1"]
    int bugIndex = int.Parse(arguments[0]);
    string direction = arguments[1];
    int step = int.Parse(arguments[2]);

    if (bugIndex >= 0 && bugIndex < field.Length //checking if enters
        && field[bugIndex] == 1)
    {
        field[bugIndex] = 0;

        // Find bug position
        if (direction == "right")
        {
            int landIndex = bugIndex + step;
            if (landIndex > field.Length - 1)
            {
                continue;
            }
            if (field[landIndex] == 1)
            {
                while (field[landIndex] == 1)
                {
                    landIndex += step;
                    if (landIndex > field.Length - 1)
                    {
                        break;
                    }
                }
            }

            if (landIndex <= field.Length - 1)
            {
                field[landIndex] = 1;
            }
        }
        else if (direction == "left")
        {
            int landIndex = bugIndex - step;
            if (landIndex < 0)
            {
                continue;
            }
            if (field[landIndex] == 1)
            {
                while (field[landIndex] == 1)
                {
                    landIndex -= step;
                    if (landIndex < 0)
                    {
                        break;
                    }
                }
            }

            if (landIndex >= 0)
            {
                field[landIndex] = 1;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", field));