using Content_Manegement.BusinessLayer.Services;
using Content_Manegement.DataLayer.NHibernateConfiguration;
using Content_Manegement.Entities;
using Content_Manegement.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Content_Manegement.Test.TestCases
{
   public class ExceptionTest
    {
        private readonly AdminServices _AdminServices;
        private readonly CustomerServices _CustomerServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _AdminServices = new AdminServices(_session);
            _CustomerServices = new CustomerServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_EmailNotFoundForAdmin()
        {
            Admin admin = new Admin()
            {
                Email = "",
                Password = ""
            };
            //Assert
            var ex = Assert.Throws<EmailNotFoundException>(() => _AdminServices.Login(admin.Email, admin.Password));
            Assert.Equal("Email Not Found ", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_EmailNotFoundForCustomer()
        {
            Customer customer = new Customer()
            {

                Email = "",

                Password = "",

            };
            //Assert
            var ex = Assert.Throws<EmailNotFoundException>(() => _CustomerServices.Login(customer.Email, customer.Password));
            Assert.Equal("Email Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ArticleNotFound()
        {
            Articles articles = new Articles()
            {
                Status = "",
                Access = "",
                Description = "",
                ArticleId = 1,
                Category = "",
                CustomerId = 1,
                Language = "",
                Featured = "",
                Note = "",
                Tags = "",
                Title = ""
            };
            //Assert
            var ex = Assert.Throws<ArticleNotFoundException>(() => _CustomerServices.SearchSArticle(articles));
            Assert.Equal(" Article Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_FieldCannotblankForCustomer()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                Email = "",
                Name = "",
                Password = "",
                PhoneNumber = "111111",
            };

            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _CustomerServices.RegisterCustomer(customer));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_FieldCannotblankForMenu()
        {
            Menu menu = new Menu()
            {
                MenuId = 1,
                Description = "",
                MenuType = "",
                Title = "",
                TitMenuPermision = ""
            };

            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AdminServices.CreateMenu(menu));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
    }
}
