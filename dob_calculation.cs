using System;

Console.WriteLine("Enter the DOB: ");
var dob = DateTime.Parse(Console.ReadLine());
// Console.WriteLine(dob);
var today  = DateTime.Today;
// Console.WriteLine(today);
var year = dob.Year;
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Not a leap year");

}
var B_hours = dob.Hour;
var t_hours = today.Hour;
var hours = t_hours - B_hours;
Console.WriteLine("Hours: " + hours);
var Difference_In_Time =( today.Subtract( dob));
var days = Difference_In_Time.TotalDays;

//var Difference_In_Days = Difference_In_Time / (1000 * 3600 * 24);
//Console.WriteLine(Difference_In_Time);

var age = Math.Round(days / (365));
Console.WriteLine("Age" + age);
var month = Math.Round((days - (365 * age)) / 30);
Console.WriteLine("Month" + month);
var weeks = Math.Round((days - ((365 * age) + (30 * month))) / 4);
Console.WriteLine("Weeks" + weeks);
var Days = Math.Round((days - ((365 * age) + (30 * month) + (4 * weeks))));
Console.WriteLine("Days" + Days);
