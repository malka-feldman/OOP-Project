using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductDAL productDAL = new ProductDAL();
            Console.WriteLine(productDAL.printList());

            try
            {
                productDAL.Delete(7);
            }
            catch (ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Testing update method should return a bool");
            try
            {
                Console.WriteLine(productDAL.Update(new Product(2, "desktop", 32.23)));
            }
            catch(ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Testing retrieve method should return a product");
            try
            {
                Console.WriteLine(productDAL.Retrieve(7));
            }
            catch (ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }
            //this has been tested
            /*Console.WriteLine("TESTING create METHOD");
            try
            {
                Console.WriteLine(productDAL.Create(new Product(6, "phone", 32.23)));
            }
            catch (ProdAlreadyExistsException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
}
