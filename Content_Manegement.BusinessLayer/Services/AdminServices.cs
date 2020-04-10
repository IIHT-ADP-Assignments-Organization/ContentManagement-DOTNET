using Content_Manegement.BusinessLayer.Interfaces;
using Content_Manegement.DataLayer.NHibernateConfiguration;
using Content_Manegement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }
        public int CreateBanner(Banners banners)
        {
            Banners ObjBanner = new Banners();
            var BannerId = ObjBanner.BannerId;
            return BannerId;
        }

        public int CreateCategory(Category category)
        {
            Category ObjCategory = new Category();
            var CategoryId = ObjCategory.CategoryId;
            return CategoryId;
        }

        public int CreateMenu(Menu menu)
        {
            Menu ObjMenu = new Menu();
            var MenuId = ObjMenu.MenuId;
            return MenuId;
        }

        public int CreateModule(Module module)
        {
            Module ObjModule = new Module();
            var ModuleId = ObjModule.ModuleId;
            return ModuleId;
        }

        public bool DeleteBanner(int BannerId)
        {
            return true;
        }

        public bool DeleteCategory(int CategoryId)
        {
            return true;
        }

        public bool DeleteMenu(int MenuId)
        {
            return true;
        }

        public bool DeleteModule(int ModuleId)
        {
            return true;
        }

        public Banners EditBanner(Banners banners)
        {
            Banners ObjBanner = new Banners();
            return ObjBanner;
        }

        public Category EditCategory(Category category)
        {
            Category ObjCategory = new Category();
            return ObjCategory;
        }

        public Menu EditMenu(Menu menu)
        {
            Menu ObjMenu = new Menu();
            return ObjMenu;
        }

        public Module EditModule(Module module)
        {
            Module ObjModule = new Module();
            return ObjModule;
        }

        public Banners GetBanners(Banners banners)
        {
            Banners ObjBanner = new Banners();
            return ObjBanner;
                
        }

        public Category GetCategory(Category category)
        {
            Category ObjCategory = new Category();
            return ObjCategory;
        }

        public Menu GetMenu(Menu menu)
        {
            Menu ObjMenu = new Menu();
            return ObjMenu;
        }

        public Module GetModule(Module module)
        {
            Module ObjModule = new Module();
            return ObjModule;
        }

        public bool Login(string Email, string Password)
        {
            return true;
        }

        public Banners ViewBanner()
        {
            Banners ObjBanner = new Banners();
            return ObjBanner;

        }

        public Category ViewCategory()
        {
            Category ObjCategory = new Category();
            return ObjCategory;
        }

        public Menu ViewMenu()
        {
            Menu ObjMenu = new Menu();
            return ObjMenu;
        }

        public Module ViewModule()
        {
            Module ObjModule = new Module();
            return ObjModule;
        }
    }
}
