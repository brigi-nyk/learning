using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        

        /// <summary>
        /// Validate the order  data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
