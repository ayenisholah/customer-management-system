using System;
namespace SCM.BL
{
    public class Order
    {
        public Order()
        {
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        public Order Retrieve(int orderId)
        {
            // code that retrieves the specified order
            return new Order();
        }
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
