using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvasive
{
   public  class ProductDependency
    {
       public int ID { get; set; }

       public int ParentProductID { get; set; }

       public int ChildProductID { get; set; }
    }
}
