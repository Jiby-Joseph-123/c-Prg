string[] name = new string[5];
string[] destinstion= new string[5];

for(int i=0; i<5;i++)
{
    Console.WriteLine("Enter the name of passenger:");
    name[i] = Console.ReadLine();
}

foreach (var item in name)
{
    Console.WriteLine(item);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the destination of passenger:");
    destinstion[i] = Console.ReadLine();
}

foreach (var item in destinstion)
{
    Console.WriteLine(item);
}

var myList = new List<string>();
myList.AddRange(name);
myList.AddRange(destinstion);
string[] array = myList.ToArray();

Console.WriteLine("New array: ");

foreach (var item in array)
{
    Console.WriteLine(item);
}