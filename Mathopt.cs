using System;

Console.WriteLine("Enter the choice:");
int count = 0;
while(count ==0)
{

Console.WriteLine("F. Enter F for Odd flight numbers");
Console.WriteLine("W. Enter W for Even flight numbers.");
Console.WriteLine("Q. Enter Q for Prime flight numbers.");
Console.WriteLine("N. Enter N for Fibonacci flight numbers.");
Console.WriteLine("A. Enter A for Amstrong flight numbers.");
    Console.WriteLine("E. Exit");
 string input = Console.ReadLine();

    switch (input)
        {
        case "F":
            for (int i = 100; i < 120; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("F" + i);
            }
            break;
        case "W":
            for (int i = 100; i < 120; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("W" + i);
            }
            break;
        case "Q":
            int k;
            for (k = 100; k <= 150; k++)
            {
                count = 0;
                for (int j = 2; j <= k / 2; j++)
                {
                    if (k % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Q"+k);
                }
               
            }
            break;
        case "N":
            int f1 = 55;
            int f2 = 89;
            int f3 = 0;
            int n = 0;
            while(n<10)
            {
                f3 = f1 + f2;
                f1= f2;
                f2= f3;
                Console.WriteLine("N" + f3);
                n++;
            }
            break;
        case "A":
            
            for (int i = 100; i < 999; i++)
            {
                int temp = i;
                int reminder = 0;
                int result = 0;
                while(temp!=0)
                {
                    reminder = temp % 10;
                    result += reminder * reminder * reminder;
                    temp /= 10;
                }
                if (result == i)
                {
                    Console.WriteLine("A" + result);
                }
            }
            break;

        case "E":
            count= 1;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
    

}