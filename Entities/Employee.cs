using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee: Person
    {
        public int Salary { get; set; }

        public Employee(string name, int id, int salary) : base(name, id)
        {
            salary = Salary;
        }
    }
}
