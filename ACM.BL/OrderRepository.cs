using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository 
    {

        //Retrieve one order
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (order.OrderId == 10)
            {
                order.OrderDate = new DateTimeOffset(
                    DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save(Order order)
        {
            //Code that saves the defined product
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        //Called an Insert Stored Procedure
                    }
                    else
                    {
                        //Called an Update Stores Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
