
using System.Collections.Immutable;

Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

string input = Console.ReadLine();

while (input != "Revision")
{
    string[] arguments = input.Split(", ");
    string shop = arguments[0];
    string product = arguments[1];
    double price = double.Parse(arguments[2]);

    if (shops.ContainsKey(shop))
    {
        shops[shop].Add(product, price);
    }

    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }

    if (!shops[shop].ContainsKey(product))
    {
        shops[shop].Add(product, price);
    }


    input = Console.ReadLine();
}

shops = shops.OrderBy(shops => shops.Key).ToDictionary(shops => shops.Key, shops => shops.Value);

foreach (var item in shops)
{
    Console.WriteLine($"{item.Key}-> ");
    foreach (var (product, price) in item.Value)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}