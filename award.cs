Console.WriteLine("Enter the name: ");
 string name = Console.ReadLine();
Console.WriteLine("enter the total miles travelled :");
int miles = Convert.ToInt32(Console.ReadLine());
if (miles > 10000 && miles < 20000)

    Console.WriteLine("Award 10 frequent flyer");

else if (miles < 50000)
    Console.WriteLine("Award 20 frequent flyer");
else if (miles < 100000)
    Console.WriteLine("Award 30 frequent flyer");
else 
    Console.WriteLine("Award 30 frequent flyer");




