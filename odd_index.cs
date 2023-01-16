using System;

decimal[] array = new decimal[10];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the fare in decimal:");
   decimal fare = Convert.ToDecimal(Console.ReadLine());
    for (int j = 0; j < 5; j++)
    {


        if (j % 2 != 0)
        {
            array[i] = fare;
            break;
        }
        else
        {
            array[i] = 0;
        }
    }
}
foreach (var item in array)
{
    Console.WriteLine(item);
}