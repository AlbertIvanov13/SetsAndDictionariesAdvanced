
int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    string[] items = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
    string color = items[0];

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe[color] = new Dictionary<string, int>();
        for (int j = 1; j < items.Length; j++)
        {
            if (!wardrobe[color].ContainsKey(items[j]))
            {
                wardrobe[color][items[j]] = 1;
            }
            else
            {
                wardrobe[color][items[j]]++;
            }
        }
    }
    else
    {
        for (int j = 1; j < items.Length; j++)
        {
            if (wardrobe[color].ContainsKey(items[j]))
            {
                wardrobe[color][items[j]]++;
            }
            else
            {
                wardrobe[color][items[j]] = 1;
            }
        }
    }
}

string[] searchedClothe = Console.ReadLine().Split();
string searchedColor = searchedClothe[0];
string clothe = searchedClothe[1];

foreach (var item in wardrobe)
{
    Console.WriteLine($"{item.Key} clothes:");
    foreach (var newItem in item.Value)
    {
        if (newItem.Key == clothe && item.Key == searchedColor)
        {
            Console.WriteLine($"* {newItem.Key} - {newItem.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {newItem.Key} - {newItem.Value}");
        }
    }
}