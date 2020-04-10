using Content_Manegement.BusinessLayer.Interfaces;
using Content_Manegement.DataLayer.NHibernateConfiguration;
using Content_Manegement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.BusinessLayer.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IMapperSession _session;

        public CustomerServices(IMapperSession session)
        {
            _session = session;
        }
        public int AddArticle(Articles articles)
        {
            Articles ObjArticles = new Articles();
            var BannerId = ObjArticles.ArticleId;
            return BannerId;
        }

        public bool DeleteArticle(int ArticleId)
        {
            return true;
        }

        public Articles EditArticle(Articles articles)
        {
            Articles ObjArticles = new Articles();
            return ObjArticles;
        }

        public Articles GetArticles(Articles articles)
        {
            Articles ObjArticles = new Articles();
            return ObjArticles;
        }

        public bool Login(string Email, string Password)
        {
            return true;
        }

        public Customer RegisterCustomer(Customer customer)
        {
            Customer ObjCustomer = new Customer();
            return ObjCustomer;
        }

        public Articles SearchSArticle(Articles articles)
        {
            Articles ObjArticles = new Articles();
            return ObjArticles;
        }

        public Articles ViewArticles()
        {
            Articles ObjArticles = new Articles();
            return ObjArticles;
        }
    }
}
