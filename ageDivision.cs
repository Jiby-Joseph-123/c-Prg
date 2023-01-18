DateTime[] dobArray = new DateTime[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter the dob :");
    dobArray[i] = Convert.ToDateTime(Console.ReadLine());


}
//Console.WriteLine(DateTime.Now.Year);
var today = DateTime.Today.Year;

foreach (DateTime dob in dobArray)
{
    var age = (today - dob.Year);
    if (age < 10)

        Console.WriteLine("kid");

    else if (age < 30)
        Console.WriteLine("Youth");
    else if (age < 60)
        Console.WriteLine("Adult");
    else
        Console.WriteLine("older");
}



