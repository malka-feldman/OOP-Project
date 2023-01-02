using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SalesRep: Employee
    {
        public double CommisionRate { get; set; }
        public SalesRep(string name, int id, int salary) : base(name, id, salary)
        {

        }
    }
}
