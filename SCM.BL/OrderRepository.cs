using System;
namespace SCM.BL
{
    public class OrderRepository
    {
        public OrderRepository()
        {
        }

        public Order Retrieve(int orderId)
        {
            // create the instance of the order class
            // pass in the requested id

            Order order = new Order(orderId);

            // code that retrieves the defined order
            // a populated order

            if (orderId == 10)
            {
                // use current year in hard-coded data
                order.OrderDate =
                    new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
