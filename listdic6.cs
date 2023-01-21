using System;


var passengers = new List<Dictionary<string, object>>();

while (true)
{
    Console.WriteLine("1. Add new list");
    Console.WriteLine("2. view");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
            AddPassenger(passengers);
            break;

        case "2":
            ViewPassenger(passengers);
            break;
        default:
            Console.WriteLine("invalid choice");
            break;
    }
}

static void AddPassenger(List<Dictionary<string, object>> passengers)
{
    string dest;
    string source;
    int dist;
    int fare;
    Console.WriteLine("Enter the source : ");
    source = Console.ReadLine();
    Console.WriteLine("Enter the destination : ");
    dest = Console.ReadLine();
    Console.WriteLine("Enter the distsnce: ");
    dist = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the fare:");
    fare = Convert.ToInt32(Console.ReadLine());


    var dic = new Dictionary<string, object>()
            {
                {"Source",source },
                { "Destination", dest },
                { "Distance", dist },
                { "Fare", fare }
            };
    passengers.Add(dic);
}

static void ViewPassenger(List<Dictionary<string, object>> passengers)
{
    var lst = new List<int>();
    foreach (var item in passengers)
    {
        Console.WriteLine($"Source {item["Source"]}| Destination {item["Destination"]}| Distance {item["Distance"]} |Fare {item["Fare"]}");

        lst.Add((int)item["Distance"]);
    }
    var minimum = lst.Min();
    var maximum = lst.Max();
    Console.WriteLine("Minimum:" + minimum);
    Console.WriteLine("Maximum:" + maximum);
}