
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

numbers = numbers.OrderByDescending(x => x).Take(3).ToArray();

Console.WriteLine(string.Join(" ", numbers));