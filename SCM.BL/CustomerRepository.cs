using System;
using System.Linq;

namespace SCM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

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
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
