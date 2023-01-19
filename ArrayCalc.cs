int[] MaxValue = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("ENter the overWeight:");
    int over = Convert.ToInt32(Console.ReadLine());
    MaxValue[i] = over * 15;
}

for (int i = 0; i < MaxValue.Length; i++)
{
    for (int j = i+1; j < MaxValue.Length; j++)
    {
        if (MaxValue[i] > MaxValue[j])
        {
            int temp = MaxValue[i];
            MaxValue[i] = MaxValue[j];
            MaxValue[j] = temp;
        }
    }
}

int max = MaxValue[MaxValue.Length - 1];
Console.WriteLine("Max value:" + max);
int sum = 0;
Console.WriteLine("Sorted array:");
foreach (var item in MaxValue)
{
    Console.WriteLine(item);
    sum+= item;
}
Console.WriteLine("Sum of value:"+sum);
