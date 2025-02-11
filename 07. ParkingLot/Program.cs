
HashSet<string> parking = new HashSet<string>();

string input = Console.ReadLine();

while (input != "END")
{
    string[] arguments = input.Split(", ");
    string direction = arguments[0];
    string carNumber = arguments[1];

    if (direction == "IN")
    {
        parking.Add(carNumber);
    }
    else
    {
        parking.Remove(carNumber);
    }

    input = Console.ReadLine();
}

if (parking.Count > 0)
{
    foreach (string car in parking)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}