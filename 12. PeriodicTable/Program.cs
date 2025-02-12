
int number = int.Parse(Console.ReadLine());

HashSet<string> chemicalElements = new HashSet<string>();

for (int i = 0; i < number; i++)
{
    string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (string element in elements)
    {
        chemicalElements.Add(element);
    }
}

Console.WriteLine(string.Join(" ", chemicalElements.OrderBy(x => x)));