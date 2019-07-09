using AnonseWeb.Controllers;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.Service.SearchService;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace AnonseWeb
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            container.RegisterType<IAdvertisementService, AdvertisementService>();
            container.RegisterType<ISearchService, SearchService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}