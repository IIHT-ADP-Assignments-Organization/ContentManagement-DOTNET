using Content_Manegement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.BusinessLayer.Interfaces
{
    public interface ICustomerServices
    {
        Customer RegisterCustomer(Customer customer);
        bool Login(string Email, string Password);
        int AddArticle(Articles articles);
        Articles EditArticle(Articles articles);
        Articles GetArticles(Articles articles);
        Articles ViewArticles();//view all article
        bool DeleteArticle(int ArticleId);
        Articles SearchSArticle(Articles articles);

    }
}
