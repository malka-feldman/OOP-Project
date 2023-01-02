using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Manager:Employee
    {
        public bool vetek { get; set; }

        public Manager(string name, int id, int salary) : base(name, id, salary)
        {
            this.vetek = vetek;
        }   
    }
}
