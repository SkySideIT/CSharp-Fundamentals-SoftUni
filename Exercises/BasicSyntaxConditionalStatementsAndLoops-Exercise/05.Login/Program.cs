string username = Console.ReadLine();

//char[] charArray = username.ToCharArray();
//Array.Reverse(charArray);
//var stringReverse = new string(charArray);

string password = "";
for (int i = username.Length-1; i >= 0; i--)
{
    password += username[i];
}

int attempts = 4;

while (attempts > 0)
{
    attempts -= 1;
    string typedPassword = Console.ReadLine();
    if (password == typedPassword)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else
    {
        if (attempts == 0)
        {
            Console.WriteLine($"User {username} blocked!");
        }
        else
        {
            Console.WriteLine("Incorrect password. Try again.");
        }
    }
}