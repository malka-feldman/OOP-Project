using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using OOPPROJECT1;

namespace BLL
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductBLL prodB = new ProductBLL(new ProductDAL());
            //testing print method
            Console.WriteLine(prodB.printBLLList());

            Console.WriteLine("Testing create method");
            try
            {
                prodB.Create(new Product(6, "charger", 2.2));
            }
            catch (ProdAlreadyExistsException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(prodB.printBLLList());
            /*Console.WriteLine("Testing retrieve method");
            try
            {
                prodB.Retrieve(6);
            }
            catch (ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(prodB.printBLLList());*/
            /*Console.WriteLine("Testing delete method");
            try
            {
                prodB.Delete(6);
            }
            catch (ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(prodB.printBLLList()); */
            Console.WriteLine("Testing update method");
            try
            {
                prodB.Update(new Product(1, "desktop", 32.23));
            }
            catch (ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(prodB.printBLLList());

        }
    }
}
