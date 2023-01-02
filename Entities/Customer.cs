using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using OOPPROJECT1;

namespace Entities
{
    public class Customer: Person
    {
        private CreditCard cc;

        public Customer(string name, int id) :base(name, id)
        {
            cc = new CreditCard();
        }
    }
}
