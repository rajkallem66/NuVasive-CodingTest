using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nuvasive.DAL;

namespace Nuvasive
{
    public class ProcessOrder
    {
        public void processOrder(List<OrderDetail> orderDetails)
        {
            Dimensions dim = new Dimensions();
            dim.Length = 6;
            dim.Width = 6;
            dim.Height = 4;

            List<OrderDetail> lstOfOrderDetailToAdd = new List<OrderDetail>();

            foreach (OrderDetail orderDetail in orderDetails)
            {
                Product p = ProductDAL.GetProduct(orderDetail.ID);
                Dimensions d = new PackageProducts(dim, p.Length, p.Width, p.Height).AddProduct();

                if (dim.Length != d.Length)
                {
                    dim = new Dimensions() { Length = d.Length, Width = d.Width, Height = d.Height };
                }
                else
                {
                    if (p.Length > 6 || p.Width > 6 || p.Height > 4)
                    {
                        // Add Cannot process list 
                    }
                    else
                    {
                        lstOfOrderDetailToAdd.Add((orderDetail));
                    }
                }
            }
            if (lstOfOrderDetailToAdd.Count > 0)
            {
                processOrder(lstOfOrderDetailToAdd);
            }
        }
    }
}
