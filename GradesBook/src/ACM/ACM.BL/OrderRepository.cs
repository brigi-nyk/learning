using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //code that retrieves the defined customer
            var order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0)); 
            }
            return order;
        }

        /// <summary>
        /// Retrieve all order 
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            //code that retrieves the defined order 

            return new List<Order>();
        }

        /// <summary>
        /// Saves the current order 
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves teh defined order 

            return true;
        }
    }
}
