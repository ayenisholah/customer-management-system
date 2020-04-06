using System;
using Xunit;

namespace SCM.BL.Test
{
    public class CustomerTest
    {
        [Fact]
        public void ValidateValid()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Ayeni",
                EmailAddress = "ayenisholah@yahoo.com"
            };

            var expected = true;
            // act

            var actual = customer.Validate();
            // assert

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ValidateMissingLastName()
        {
            // arrange
            var customer = new Customer
            {
                EmailAddress = "ayenisholah@yahoo.com"
            };

            var expected = false;
            // act

            var actual = customer.Validate();
            // assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void StaticTest()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Shola";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Tayo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Titilayo";
            Customer.InstanceCount += 1;

            //act

            //assert
            Assert.Equal(3, Customer.InstanceCount);
        }
    }
}
