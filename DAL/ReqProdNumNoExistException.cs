using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReqProdNumNoExistException : Exception
    {
        public ReqProdNumNoExistException() : base("Product doesn't exist")
        {

        }

        public ReqProdNumNoExistException(string messageValue) : base(messageValue)
        {

        }

        public ReqProdNumNoExistException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
}
