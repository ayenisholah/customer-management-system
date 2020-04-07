using System;
using System.Collections.Generic;

namespace SCM.BL
{
    public class AddressRepository
    {
        public AddressRepository()
        {
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that retrieves the defined addresses for the customer

            // Temporary hard-coded values to return a set of
            // addresses for a customer

            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Engr Dele street",
                StreetLine2 = "Angwan maigero",
                City = "Kaduna",
                State = "Kaduna",
                Country = "Nigeria",
                PostalCode = "800244",
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Ayinde Bisi Close",
                StreetLine2 = "Gani Animashaun street",
                City = "Akowonjo",
                State = "Lagos",
                Country = "Nigeria",
                PostalCode = "100275",
            };
            addressList.Add(address);

            return addressList;
        }

        public Address Retrieve(int addressId)
        {
            // create the instance of the address class
            // pass in the requested id
            var address = new Address(addressId);

            // code that retrieves the defined address

            // temporary hard-coded value to return a populated address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Engr Dele street";
                address.StreetLine2 = "Angwan maigero";
                address.City = "Kaduna";
                address.State = "Kaduna";
                address.Country = "Nigeria";
                address.PostalCode = "800244";
            }
            return address;
        }

        public bool Save(Address address)
        {
            // code that saves the passed in address

            return true;
        }
    }
}
