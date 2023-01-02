using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPPROJECT1
{
    public class Product
    {
        public int ProductNum { get; set; }
        public string ProductName { get; set; }

        public double CPU { get; set; }

        //public int AmountInStock { get; set; }  

        public Product(int productNum, string productName, double cPU)
        {
            ProductNum = productNum;
            ProductName = productName;
            CPU = cPU;
        }

        public override string ToString()
        {
            return $"Product Number: {ProductNum} Product name: {ProductName} cpu: {CPU}";
        }
    }
}
