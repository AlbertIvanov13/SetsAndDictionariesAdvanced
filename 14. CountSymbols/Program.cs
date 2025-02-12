
string text = Console.ReadLine();

Dictionary<char, int> occurrences = new Dictionary<char, int>();

foreach (var item in text)
{
	if (!occurrences.ContainsKey(item))
	{
		occurrences[item] = 0;
	}

	occurrences[item]++;
}

foreach (var (symbol, times) in occurrences.OrderBy(x => x.Key))
{
	Console.WriteLine($"{symbol}: {times} time/s");
}