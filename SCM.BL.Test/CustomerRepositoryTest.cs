using System;
using System.Collections.Generic;
using Xunit;

namespace SCM.BL.Test
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "ayenisholah@yahoo.com",
                FirstName = "Shola",
                LastName = "Ayeni"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert

            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "ayenisholah@yahoo.com",
                FirstName = "Shola",
                LastName = "Ayeni",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Engr Dele street",
                        StreetLine2 = "Angwan maigero",
                        City = "Kaduna",
                        State = "Kaduna",
                        Country = "Nigeria",
                        PostalCode = "800244",
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Ayinde Bisi Close",
                        StreetLine2 = "Gani Animashaun street",
                        City = "Akowonjo",
                        State = "Lagos",
                        Country = "Nigeria",
                        PostalCode = "100275",
                    }
                }
            };

            // -- Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);


            }
        }
    }
}