using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvasive.DAL
{
    public static class ProductDAL
    {
        public static List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();

            Product product1 = new Product();
            product1.Height = 2;
            product1.Length = 2;
            product1.Width = 2;
            product1.SKU = "Item1";
            product1.IsAvailable = true;
            product1.ID = 3;

            Product product2 = new Product();
            product2.Height = 2;
            product2.Length = 2;
            product2.Width = 2;
            product2.SKU = "Item2";
            product2.IsAvailable = true;
            product2.ID = 9;

            Product product3 = new Product();
            product3.Height = 2;
            product3.Length = 2;
            product3.Width = 2;
            product3.SKU = "Item3";
            product3.IsAvailable = true;
            product3.ID = 11;

            Product product4 = new Product();
            product4.Height = 2;
            product4.Length = 2;
            product4.Width = 1;
            product4.SKU = "Item4";
            product4.IsAvailable = true;
            product4.ID = 1;

            list.Add(product1);
            list.Add(product2);
            list.Add(product3);
            list.Add(product4);

            return list;
        }

        public static Product GetProduct(int ID)
        {
            var products = GetProducts();
            if (products.Count > 0)
            {
                var product = (from p in products
                               where p.ID == ID
                               select p).FirstOrDefault();
                return product;
            }
            return null;
        }

        public static bool IsProductAvailable(int productID)
        {
            var products = GetProduct(productID);
            if (products != null)
                return true;
            return false;
        }
    }
}
