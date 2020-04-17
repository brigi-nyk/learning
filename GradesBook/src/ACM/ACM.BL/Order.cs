using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order: EntityBase, ILoggable
    {
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem>  OrdersItems { get; set; }

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
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        public string Log() => $"{OrderId}: Date: {OrderDate.Value.Date} State: {EntityState}";
        
    }
}
