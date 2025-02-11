
double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

Dictionary<double, int> dictionary = new Dictionary<double, int>();

int counter = 0;
foreach (double number in numbers)
{
	if (!dictionary.ContainsKey(number))
	{
		dictionary.Add(number, counter);
	}

	dictionary[number]++;
}

foreach (var (number, times) in dictionary)
{
    Console.WriteLine($"{number} - {times} times");
}