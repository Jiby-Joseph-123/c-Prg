string[] destination = new string[10];
decimal[] fare = new decimal[10];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter destination: ");
    destination[i] = Console.ReadLine();
    
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter fare: ");
    fare[i] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("Enter a number less than 5: ");
int num = Convert.ToInt32( Console.ReadLine() );

if(num < 5)
{
    Console.WriteLine("Destination: " + destination[num]);
    Console.WriteLine("Fare: " + fare[num]);
}
else
{
    Console.WriteLine("Invalid number ");
}