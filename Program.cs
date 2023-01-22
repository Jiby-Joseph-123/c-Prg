using EmployeeDetails;

var employees = new List<EmployeeDetail>();
int count = 0;
while (count == 0)
{
    Console.WriteLine("1. Add Employee.");
    Console.WriteLine("2. View Employees.");
    Console.WriteLine("3. Exit.");
    Console.WriteLine("Enter the choice:");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddEmployee(employees);
            break;
        case 2:
            ViewEmployee(employees);
            break;
        case 3:
            count = 1;
            break;

    }

}

static void AddEmployee(List<EmployeeDetail> employees)
{
    var employee = new EmployeeDetail();
    Console.WriteLine("Enter the Name:");
    employee.Name = Console.ReadLine();
    Console.WriteLine("Enter the age: ");
    employee.Age = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the salary: ");
    employee.Salary = Convert.ToDecimal(Console.ReadLine());

    employees.Add(employee);
}

static void ViewEmployee(List<EmployeeDetail> employees)
{
    foreach (var item in employees)
    {
        Console.WriteLine(item);
    }
}