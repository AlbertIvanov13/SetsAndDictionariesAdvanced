﻿
int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = lengths[0];
int m = lengths[1];

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    firstSet.Add(number);
}

for (int i = 0; i < m; i++)
{
    int number = int.Parse(Console.ReadLine());

    secondSet.Add(number);
}

foreach (var number in firstSet)
{
    if (secondSet.Contains(number))
    {
        Console.Write(number + " ");
    }
}