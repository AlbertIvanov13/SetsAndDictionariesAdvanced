
int continentsCount = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < continentsCount; i++)
{
    string[] input = Console.ReadLine().Split();
    string continent = input[0];
    string country = input[1];
    string city = input[2];

    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent].Add(country, new List<string>());
    }

    continents[continent][country].Add(city);
}


foreach (var continent in continents)
{
    Console.WriteLine($"{continent.Key}:");
    foreach (var (country, cities) in continent.Value)
    {
        Console.Write($"    {country} -> ");
        Console.WriteLine(string.Join(", ", cities));
    }
}