decimal[] array = new decimal[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter the fare: ");
    decimal fare = Convert.ToDecimal(Console.ReadLine());
    array[i] = fare;
}
Console.WriteLine("Sorted array: ");
for (int i = 0; i < array.Length; i++)
{
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
           decimal temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
            
    }
}
foreach (decimal fare in array)
{
    Console.WriteLine(fare.ToString());
}
Console.WriteLine("Reversed array: ");
Array.Reverse(array);
foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.WriteLine("Enter the name to be find");
Decimal key = Convert.ToDecimal(Console.ReadLine());
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


decimal value =0;
Boolean flag1 = false;
for (int i = 0;i < 3;i++)
{
    for (int j = i+1; j < 10; j++)
    {
        if (array[i] == array[j])
        {
           flag1 = true;
            value= array[j];
            break;

        }
    }
}
if (true)
{
    Console.WriteLine("Duplivate value = " + value);
}
else
{
    Console.WriteLine("No dulicate");
}
