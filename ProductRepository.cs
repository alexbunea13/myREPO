using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            Object myObject = new Object();
            Console.WriteLine("Object: " + myObject.ToString());
            Console.WriteLine("Product: " + product.ToString());
            //temporarly hardcoded values to return a populated product
            if (productId == 2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = " Assorted Siz";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            var succes = true;

            if (product.HasChanges && product.isValid)
            {
                if(product.isNew)
                {
                    //Call an Insert Stored Procedure
                }
                else
                {
                    //Call an Update Stored Procedure
                }
            }
            return succes;
        }

    }
}
