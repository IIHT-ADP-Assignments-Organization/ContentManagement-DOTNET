using Content_Manegement.BusinessLayer.Services;
using Content_Manegement.DataLayer.NHibernateConfiguration;
using Content_Manegement.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace Content_Manegement.Test.TestCases
{
   public class BoundaryTest
    {
        private readonly AdminServices _AdminServices;
        private readonly CustomerServices _CustomerServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public BoundaryTest()
        {
            _AdminServices = new AdminServices(_session);
            _CustomerServices = new CustomerServices(_session);
        }

        [Fact]
        public void Boundary_Testfor_ValidEmail()
        {
            //Action
            var customer = new Customer()
            {
                
                Email = "abc@gmail.com",
              
            };

            bool isEmail = Regex.IsMatch(customer.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public void Boundary_Testfor_ValidContactNumber()
        {
            //Action
            var customer = new Customer()
            {

               PhoneNumber="11111"

            };

            //Assert
            Assert.Equal(10, customer.PhoneNumber.ToString().Length);
        }

        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            var customer = new Customer()
            {
               
                Password = "12345678"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = customer.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


        [Fact]
        public void BoundaryTest_ForPassword_LengthForAdmin()
        {
            Admin admin = new Admin()
            {
                Email = "",
                Password = "1111"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = admin.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void Boundary_Testfor_ValidEmailforAdmin()
        {
            //Action
            Admin admin = new Admin()
            {
                Email = "",
                Password = "1111"
            };

            bool isEmail = Regex.IsMatch(admin.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

    }
}
