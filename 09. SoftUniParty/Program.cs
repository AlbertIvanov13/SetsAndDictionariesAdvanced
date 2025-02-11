
HashSet<string> VIPGuests = new HashSet<string>();
HashSet<string> regularGuests = new HashSet<string>();

string guest = Console.ReadLine();

while (guest != "PARTY")
{
    if (guest.Length == 8)
    {
        if (char.IsDigit(guest[0]))
        {
            VIPGuests.Add(guest);
        }
        else
        {
            regularGuests.Add(guest);
        }
    }
    else
    {
        guest = Console.ReadLine();
        continue;
    }
    guest = Console.ReadLine();
}

string comingGuest = Console.ReadLine();

while (comingGuest != "END")
{
    if (regularGuests.Contains(comingGuest))
    {
        regularGuests.Remove(comingGuest);
    }
    else if (VIPGuests.Contains(comingGuest))
    {
        VIPGuests.Remove(comingGuest);
    }

    comingGuest = Console.ReadLine();
}

Console.WriteLine(regularGuests.Count + VIPGuests.Count);

foreach (var item in VIPGuests)
{
    Console.WriteLine(item);
}

foreach (var item in regularGuests)
{
    Console.WriteLine(item);
}