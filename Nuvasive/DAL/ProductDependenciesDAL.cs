using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvasive.DAL
{
    public static class ProductDependenciesDAL
    {
        public static List<ProductDependency> GetProductDependencies(int ID)
        {
            var prodDeps = GetAllProductDepndencies();
            if (prodDeps.Count > 0)
            {
                var list = (from p in prodDeps
                            where p.ParentProductID == ID
                            select p);
                return list.ToList();
            }
            return null;
        }

        public static List<ProductDependency> GetAllProductDepndencies()
        {
            List<ProductDependency> list = new List<ProductDependency>();

            ProductDependency pd1 = new ProductDependency();
            pd1.ChildProductID = 3;
            pd1.ID = 3;
            pd1.ParentProductID = 3;

            ProductDependency pd2 = new ProductDependency();
            pd2.ChildProductID = 3;
            pd2.ID = 3;
            pd2.ParentProductID = 3;

            ProductDependency pd3 = new ProductDependency();
            pd3.ChildProductID = 3;
            pd3.ID = 3;
            pd3.ParentProductID = 3;

            list.Add(pd1);
            list.Add(pd2);
            list.Add(pd3);

            return list;
        }
    }
}
