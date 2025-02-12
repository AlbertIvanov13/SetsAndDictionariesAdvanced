
int number = int.Parse(Console.ReadLine());

HashSet<string> usernames = new HashSet<string>();

for (int i = 0; i < number; i++)
{
    string username = Console.ReadLine();

    usernames.Add(username);
}

foreach (string username in usernames)
{
    Console.WriteLine(username);
}