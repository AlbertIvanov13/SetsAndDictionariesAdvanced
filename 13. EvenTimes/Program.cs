﻿
int n = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers =  new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(number))
    {
        numbers[number] = 0;
    }

    numbers[number]++;
}

var evenTimesNumber = numbers.Single(n => n.Value % 2 == 0);

Console.WriteLine(evenTimesNumber.Key);