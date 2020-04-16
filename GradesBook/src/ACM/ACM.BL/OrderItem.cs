using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {

        public int OrderItemId { get; private set; }
        public int Quantity{ get; set; }
        public int ProductId{ get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            //code that retrieves the defined customer

            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all order items
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            //code that retrieves the defined order item

            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the current order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves teh defined order item

            return true;
        }

        /// <summary>
        /// Validate the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            //if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}

