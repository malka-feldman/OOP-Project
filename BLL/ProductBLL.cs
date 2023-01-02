using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using OOPPROJECT1;

namespace BLL
{
    public class ProductBLL
    {
        public ProductDAL prod;

        public ProductBLL(ProductDAL prod)
        {
            this.prod = prod;
        }

        public ProductBLL()
        {
            prod = new ProductDAL();
        }
        public string printBLLList()
        {
            string str = prod.printList();
            return str;
        }

        public Product Create(Product item)
        {
            try
            {
                return prod.Create(item);
            }
            catch(ProdAlreadyExistsException pe)
            {
                throw pe;
            }
        }

        public Product Retrieve(int productNum)
        {
            return prod.Retrieve(productNum);
        }

        public bool Update(Product item)
        {
            return prod.Update(item);
        }
        public void Delete(int productNum)
        {
            prod.Delete(productNum);
        }

    }
}
