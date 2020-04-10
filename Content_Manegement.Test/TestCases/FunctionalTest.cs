using Content_Manegement.BusinessLayer.Services;
using Content_Manegement.DataLayer.NHibernateConfiguration;
using Content_Manegement.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Content_Manegement.Test.TestCases
{
    public class FunctionalTest
    {
        private readonly AdminServices _AdminServices;
        private readonly CustomerServices _CustomerServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _AdminServices = new AdminServices(_session);
            _CustomerServices = new CustomerServices(_session);
        }

        [Fact]
        public void Test_For_Login()
        {
            Admin admin = new Admin()
            {
                Email = "",
                Password = ""
            };

            var Result = _AdminServices.Login(admin.Email, admin.Password);
            Assert.True(Result);
        }

        [Fact]
        public void Test_For_EditMenu()
        {
            Menu menu = new Menu()
            {
                MenuId = 1,
                Description = "",
                MenuType = "",
                Title = "",
                TitMenuPermision = ""
            };


            var Result = _AdminServices.EditMenu(menu);
            var GetMenu = _AdminServices.GetMenu(menu);
            Assert.Equal(GetMenu,Result);
        }


        [Fact]
        public void Test_For_CreateMenu()
        {
            Menu menu = new Menu()
            {
                MenuId = 1,
                Description = "",
                MenuType = "",
                Title = "",
                TitMenuPermision = ""
            };


            var Result = _AdminServices.CreateMenu(menu);
            var CreateMenu = Result.ToString();
            Assert.NotNull(CreateMenu);
        }
        [Fact]
        public void Test_For_DeleteMenu()
        {
            Menu menu = new Menu()
            {
                MenuId = 1,
               
            };
            var Result = _AdminServices.DeleteMenu(menu.MenuId); 
            Assert.True(Result);
        }


        [Fact]
        public void Test_For_CreateModule()
        {
            Module module = new Module()
            {
                ModuleId = 1,
                Access = "",
                finishPublishing = DateTime.Now,
                ShowTitle = "",
                StartPublishing = DateTime.Now,
                Status = "",
                Language = "",
                Ordering = "",
                Position = "",
                Title = ""
            };

            var Result = _AdminServices.CreateModule(module);
            var CreateModule = Result.ToString();
            Assert.NotNull(CreateModule);
        }

        [Fact]
        public void Test_For_EditModule()
        {
            Module module = new Module()
            {
                ModuleId = 1,
                Access = "",
                finishPublishing = DateTime.Now,
                ShowTitle = "",
                StartPublishing = DateTime.Now,
                Status = "",
                Language = "",
                Ordering = "",
                Position = "",
                Title = ""
            };

            var Result = _AdminServices.EditModule(module);
            var GetModule = _AdminServices.GetModule(module);
            Assert.Equal(GetModule, Result);
        }

        [Fact]
        public void Test_For_DeleteModule()
        {
            Module module = new Module()
            {
                ModuleId = 1,
               
            };
            var Result = _AdminServices.DeleteModule(module.ModuleId);
            Assert.True(Result);
        }

        [Fact]
        public void Test_For_CreateCategory()
        {
            Category category = new Category()
            {
                Access = "",
                AltText = "",
                CategoryId = 1,
                Description = "",
                Image = "",
                Language = "",
                Note = "",
                ParentCategory = "",
                Tags = "",
                Title = ""
            };

            var Result = _AdminServices.CreateCategory(category);
            var CreateCategory = Result.ToString();
            Assert.NotNull(CreateCategory);
        }

        [Fact]
        public void Test_For_EditCategory()
        {
            Category category = new Category()
            {
                Access = "",
                AltText = "",
                CategoryId = 1,
                Description = "",
                Image = "",
                Language = "",
                Note = "",
                ParentCategory = "",
                Tags = "",
                Title = ""
            };


            var Result = _AdminServices.EditCategory(category);
            var GetModule = _AdminServices.GetCategory(category);
            Assert.Equal(GetModule, Result);
        }

        [Fact]
        public void Test_For_DeleteCategory()
        {

            Category category = new Category()
            {
                
              
                CategoryId = 1,
               
            };

            var Result = _AdminServices.DeleteModule(category.CategoryId);
            Assert.True(Result);
        }

        [Fact]
        public void Test_For_CreateBanner()
        {
            Banners banners = new Banners()
            {
                BannerId = 1,
                Description = "",
                AltText = "",
                Height = "",
                Iamges = "",
                Name = "",
                Type = "",
                Width = "",
            };

            var Result = _AdminServices.CreateBanner(banners);
            var CreateBanner = Result.ToString();
            Assert.NotNull(CreateBanner);
        }

        [Fact]
        public void Test_For_EditBanner()
        {
            Banners banners = new Banners()
            {
                BannerId = 1,
                Description = "",
                AltText = "",
                Height = "",
                Iamges = "",
                Name = "",
                Type = "",
                Width = "",
            };


            var Result = _AdminServices.EditBanner(banners);
            var GetModule = _AdminServices.GetBanners(banners);
            Assert.Equal(GetModule, Result);
        }
        [Fact]
        public void Test_For_DeleteBanner()
        {

            Category category = new Category()
            {
                CategoryId = 1,

            };

            var Result = _AdminServices.DeleteModule(category.CategoryId);
            Assert.True(Result);
        }


        [Fact]
        public void Test_For_RegisterCustomer()
        {
            Customer customer = new Customer()
            {
               CustomerId=1,
               Email="",
               Name="",
               Password="",
               PhoneNumber="111111",
            };

            var Result = _CustomerServices.RegisterCustomer(customer);
            var RegisterCustomer = Result.ToString();
            Assert.NotNull(RegisterCustomer);
        }
        [Fact]
        public void Test_For_LoginForCustomer()
        {
            Customer customer = new Customer()
            {
                
                Email = "",
               
                Password = "",
           
            };

            var Result = _AdminServices.Login(customer.Email, customer.Password);
            Assert.True(Result);
        }

        [Fact]
        public void Test_For_AddArticle()
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
            var Result = _CustomerServices.AddArticle(articles);
            var AddArticle = Result.ToString();
            Assert.NotNull(AddArticle);
        }



        [Fact]
        public void Test_For_EditArticle()
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


            var Result = _CustomerServices.EditArticle(articles);
            var GetArticles = _CustomerServices.GetArticles(articles);
            Assert.Equal(GetArticles, Result);
        }
        [Fact]
        public void Test_For_SearchSArticle()
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


            var Result = _CustomerServices.SearchSArticle(articles);
            var GetArticles = _CustomerServices.GetArticles(articles);
            Assert.Equal(GetArticles, Result);
        }

        [Fact]
        public void Test_For_DeleteArticle()
        {

            Articles articles = new Articles()
            {
              
                ArticleId = 1,
                
            };


            var Result = _CustomerServices.DeleteArticle(articles.ArticleId);
            Assert.True(Result);
        }

    }
}
