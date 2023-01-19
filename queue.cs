Queue<int> BoardPass1 = new Queue<int>();
Queue<int> BoardPass2 = new Queue<int>();
Queue<int> BoardPass3 = new Queue<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("enter the pass:");
    int value  = Convert.ToInt32(Console.ReadLine());
    if (BoardPass1.Count<3)
        BoardPass1.Enqueue(value);
    else if(BoardPass2.Count<3)
        BoardPass2.Enqueue(value);
    else if (BoardPass3.Count < 3)
        BoardPass3.Enqueue(value);
    else
    {
        Random r = new Random();
        int q = r.Next(0, 2);
        if (q==0)
        {
            BoardPass1.Dequeue();
            BoardPass1.Enqueue(value);
        }
        else if(q==1)
        {
            BoardPass2.Dequeue();
            BoardPass2.Enqueue(value);
        }
        else
        {
            BoardPass3.Dequeue();
            BoardPass3.Enqueue(value);
        }

    }

}

Console.WriteLine("Elements of 1st queue:");
foreach (var item in BoardPass1)
{
    Console.WriteLine(item);
}

Console.WriteLine("Elements of 2nd queue: ");
foreach (var item in BoardPass2)
{
    Console.WriteLine(item);
}

Console.WriteLine("Elements of 3rd queue:");
foreach (var item in BoardPass3)
{
    Console.WriteLine(item);
}



