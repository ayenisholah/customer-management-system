using System;
namespace SCM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
        }

        public Customer Retrieve(int customerId)
        {
            // create the instance of the customer class
            // pass in the requested id

            Customer customer = new Customer(customerId);

            // code that retrieves the defined customer
            // temporary hard coded values to return a populated customer

            if (customerId == 1)
            {
                customer.EmailAddress = "ayenisholah@yahoo.com";
                customer.FirstName = "Shola";
                customer.LastName = "Ayeni";
            }
            return customer;

        }

        public bool Save(Customer customer)
        {
            // code that saves the passed customer
            return true;
        }
    }
}
