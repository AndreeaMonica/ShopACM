using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
        
        //Retrieve one OrderItem
        public OrderItem Retrieve(int id)
        {
            return new OrderItem();
        }

        //Retrieve all OrderItem
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        //Save the current OrderItem
        public bool Save()
        {
            return true;
        }

    }
}
