using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvasive.DAL
{
    public static class OrderDAL
    {
        public static List<Order> GetOrders()
        {
            List<Order> list = new List<Order>();

            var order1 = new Order();
            order1.ID = 1;
            order1.CountryCode = "USA";
            order1.CreateDate = System.DateTime.Today;
            order1.IsShipped = false;
            order1.OrderDetails = new List<OrderDetail>(){new OrderDetail(){ID  = 1,ProductID = 2},
                new OrderDetail(){ID  = 3,ProductID = 4}
            };

            var order2 = new Order();
            order2.ID = 2;
            order2.CountryCode = "AUS";
            order2.CreateDate = System.DateTime.Now;
            order2.IsShipped = false;
            order2.OrderDetails = new List<OrderDetail>(){new OrderDetail(){ID  = 5,ProductID = 6},
                new OrderDetail(){ID  = 7,ProductID = 8}
            };

            var order3 = new Order();
            order3.ID = 3;
            order3.CountryCode = "USA";
            order3.IsShipped = false;
            order3.OrderDetails = new List<OrderDetail>(){new OrderDetail(){ID  = 9,ProductID = 10},
                new OrderDetail(){ID  = 11,ProductID = 12}
            };

            list.Add(order1);
            list.Add(order2);
            list.Add(order3);


            return list;
        }
    }
}
