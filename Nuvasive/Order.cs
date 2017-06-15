using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvasive
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string CountryCode { get; set; }
        public bool IsShipped { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } 
    }
}

