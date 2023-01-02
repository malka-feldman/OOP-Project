using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OOPPROJECT1;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class ProductDAL
    {
        static List<Product> products = new List<Product>();
        static bool loaded = false;
        public ProductDAL()
        {
            if (loaded == false)
            {
                InitializeList();
            }
        }
        public void InitializeList()
        {
            StreamReader input = new StreamReader("TextFile1.txt");

            using (input)
            {
                while (!input.EndOfStream)
                {
                    products.Add(new Product(int.Parse(input.ReadLine()), input.ReadLine(), double.Parse(input.ReadLine())));
                }
            }
            loaded = true;
        }
        public string printList()
        {
            string str = String.Join(", ", products);
            return str;
        }

        public static void ReadAll()
        {
            ArrayList list = new ArrayList();
            foreach(Product product in products)
            {
                list.Add(product);
            }
            foreach(Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        //make a copy
        public Product Create(Product item)
        {
                foreach (Product product in products)
                {
                    if (item.ProductName == product.ProductName)
                    {
                        throw new ProdAlreadyExistsException();
                    }
                    /*else
                    {
                        products.Add(item);
                        return item;
                    }*/
                    //goes into else even though returned in if
                }
            Product newitem = new Product(item.ProductNum, item.ProductName, item.CPU);
            products.Add(newitem);
            return newitem;
         }


        public Product Retrieve(int productNum)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductNum == productNum)
                {
                    Product prod = new Product(products[i].ProductNum, products[i].ProductName, products[i].CPU);
                    return prod;
                }
            }
            throw new ReqProdNumNoExistException();
        }
        public bool Update(Product item)
        {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductNum == item.ProductNum)
                    {
                        products.RemoveAt(i);
                        products.Add(item);
                        return true;
                    }
                }
                throw new ReqProdNumNoExistException();
        }

        public void Delete(int productNum)
        {
            int index = 0;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductNum == productNum)
                    {
                        index = i;
                        products.RemoveAt(index);
                        Console.WriteLine("Deleted");
                        return;  
                    }//end if
                    /*else
                    {
                        throw new ReqProdNumNoExistException();
                    }*/
                }//end for
                throw new ReqProdNumNoExistException();
            //throws exception no matter what
            //DOESNT EXIT THE FOR LOOP
        }
    }
}

