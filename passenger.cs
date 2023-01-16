using System;

string[] array = new string[10];
int i = 0;

for (i = 0; i <= 5; i++)
{
    Console.WriteLine("Enter your name");
    string name = Console.ReadLine();
    array[i] = name;
}
foreach (string name in array)
    Console.WriteLine(name);

// Sorted array.

Array.Sort(array);
foreach (string name in array)
    Console.WriteLine(name);


// Reverse of the array.

Array.Reverse(array);
foreach (string name in array)
    Console.WriteLine(name);

//ind a name from array.
Console.WriteLine("Enter the name to be find");
string key = Console.ReadLine();
Boolean flag = false;
foreach (var item in array)
{
    if (key == item)
    {
        flag = true;
        break;
    }
}
if (flag == true)
{
    Console.WriteLine("item found");
}
else
{
    Console.WriteLine("No matches value ");
}

// Length of each element .

foreach (var item in array)
{
    Console.WriteLine("Length of " + item + ":" + item.Length);
}
// split element
Console.WriteLine("Write something with space");
    string forSplit = Console.ReadLine();
string[] splited = forSplit.Split(" ");
foreach (var item in forSplit)
{
    Console.WriteLine(item);
}

// Find the duplicate of the array.b



Boolean f = false;
string dup = null;
for (i = 0; i < 5; i++)
{
    for (int j = i + 1; j <= 5; j++)
    {

        if (array[i] == array[j])
        {
            f = true;
            dup = array[i];
            break;
        }
    }
}

if (f == true)
{
    Console.WriteLine("Duplicate element:" + dup);
}
else
{
    Console.WriteLine("No duplicate element");
}

