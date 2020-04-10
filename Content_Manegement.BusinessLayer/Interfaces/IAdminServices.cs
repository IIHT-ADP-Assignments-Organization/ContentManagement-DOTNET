using Content_Manegement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Content_Manegement.BusinessLayer.Interfaces
{
    public interface IAdminServices
    {
        bool Login(string Email,string Password);
        Menu EditMenu(Menu menu);
        int CreateMenu(Menu menu);
        Menu GetMenu(Menu menu);
        Menu ViewMenu();
        bool DeleteMenu(int MenuId);
        int CreateModule(Module module);
        Module EditModule(Module module);
        Module GetModule(Module module);
        bool DeleteModule(int ModuleId);
        Module ViewModule();//view all the module
        int CreateCategory(Category category);
        Category EditCategory(Category category);
        Category GetCategory(Category category);
        Category ViewCategory();//View all Category
        bool DeleteCategory(int CategoryId);
        int CreateBanner(Banners banners);
        Banners EditBanner(Banners banners);
        Banners GetBanners(Banners banners);
        bool DeleteBanner(int BannerId);
        Banners ViewBanner();//view all banner


    }
}
