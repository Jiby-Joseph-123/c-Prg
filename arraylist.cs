using System.Collections;

ArrayList flightNum = new ArrayList();


while (true)
{
    Console.WriteLine("1.Add flight number");
    Console.WriteLine("2.View");
    Console.WriteLine("3.quit");


    Console.WriteLine("Enter the choice:");
    int input = Convert.ToInt16(Console.ReadLine());
   
    switch (input)
    {
        case 1:
            Console.WriteLine("Enter the flight number:");
            int num = Convert.ToInt16(Console.ReadLine());
            flightNum.Add (num);
           
            break;
        case 2:
            foreach (var item in flightNum)
            {
                Console.WriteLine(item);
            }
            break;
        case 3:
            
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
}