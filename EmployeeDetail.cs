using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    internal class EmployeeDetail
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $" Name: {Name} , Age: {Age} , Salary: {Salary}.";
        }
    }
}
