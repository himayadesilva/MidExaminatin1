using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExamination1
{
    internal class Employee
    {
        // create properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }

        //create methods
        public void print()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + ", Salary: " + BasicSalary);
        }
        

    }
}
