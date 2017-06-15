using Nuvasive.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvasive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orders = OrderDAL.GetOrders();

            if (orders == null)
                return;

            var ordersToProcess = (from o in orders
                                   where o.CountryCode == "USA"
                                   select o);

            if (ordersToProcess.Count() == 0)
                return;

            var getOrdersByDate = (from o in ordersToProcess
                                   orderby o.CreateDate
                                   select o
                                  );

            foreach (var order in getOrdersByDate)
            {
                if (order.OrderDetails != null && order.OrderDetails.Count > 0)
                {
                    foreach (var orderDetail in order.OrderDetails)
                    {
                        bool isProductAvailable = ProductDAL.IsProductAvailable(orderDetail.ProductID);

                        if (isProductAvailable == false)
                            break; //Under assumption only process orders with all available products

                        // get dependent products
                        var lstDependentProducts = ProductDependenciesDAL.GetProductDependencies(orderDetail.ID);

                        bool isAvailable = true;

                        // check if dependent products in order
                        foreach (var lstDependentProduct in lstDependentProducts)
                        {
                            var dependencyProduct = (from o in order.OrderDetails
                                                     where o.ProductID == lstDependentProduct.ChildProductID
                                                     select o).FirstOrDefault();

                            //if dependend product check availablity
                            if (dependencyProduct != null)
                            {
                                isAvailable = ProductDAL.IsProductAvailable(lstDependentProduct.ChildProductID);
                                if (isAvailable == false)
                                {
                                    break;
                                }
                            }
                        }
                        if (isAvailable == false)
                            break;
                    }
                    new ProcessOrder().processOrder(order.OrderDetails);
                }
            }
        }

      
    }
}
