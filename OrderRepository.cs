using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014,2, 04, 14, 22, 44, 23, new TimeSpan(2, 14, 18));

            }
            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //temporarly hardcoded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
                orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

                if (orderId == 10)
                {
                    var orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M,
                        OrderQuantity = 2
                    };
                    orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
                }
            }
                return orderDisplay;
            
        }

        public bool Save()
        {
            return true;
        }
    }
}
