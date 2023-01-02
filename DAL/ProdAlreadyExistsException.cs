using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdAlreadyExistsException :Exception
    {
        public ProdAlreadyExistsException() : base("Product already exists")
        {

        }

        public ProdAlreadyExistsException(string messageValue) : base(messageValue)
        {

        }

        public ProdAlreadyExistsException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
}
