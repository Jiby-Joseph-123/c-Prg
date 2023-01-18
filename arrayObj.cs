using System;
string dest;
string source;
int dist;
int fare;
var passenger = new List<Dictionary<string, object>>();

while (true)
{
    Console.WriteLine("1. Add new list");
    Console.WriteLine("2. view");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":

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
            passenger.Add(dic);
            break;

        case "2":
            foreach (var item in passenger)
            {
                Console.WriteLine($"Source {item["Source"]}| Destination {item["Destination"]}| Distance {item["Distance"]} |Fare {item["Fare"]}");

            }
            break;
         case "3":
            for (int p = 0; p <passenger.Count; p++)
            {
                for (int i = p+1; i < passenger.Count; i++)
                {
                    if (IThreadPoolWorkItem[])  
                }
            }
            break;
        default:
            break;
    }
}




