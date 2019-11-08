using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if (product.ProductId == 2)
            {
                product.ProductName = "Ring";
                product.ProductDescription = "It`s Lord of the Ring";
                product.CurrentPrice = 3500M;
            }

            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Object: {product.ToString()}");

            return product;
        }

        //Save the current product
        public bool Save(Product product)
        {
            //Code that saves the defined product
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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
