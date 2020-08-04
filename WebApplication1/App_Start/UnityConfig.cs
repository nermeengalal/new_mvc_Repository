using Entity.Repository.Category;
using Entity.Repository.PropertyItems;
using Entity.Repository.PropertyOptions;
using Entity.Repository.PropertyValue;
using Services.Service.Category;
using Services.Service.PeropertyValue;
using Services.Service.PropertyItems;
using Services.Service.PropertyOptions;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IPropertyValueRepository, PropertyValueRepository>();
            container.RegisterType<IPropertyValueService, PropertyValueService>();


            //Category
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            //Property_Items
            container.RegisterType<IPropertyItemsRepository, PropertyItemsRepository>();
            container.RegisterType<IPropertyIetmsService, PropertyItemsService>();

            //Property Options
            container.RegisterType<IPropertyOptionsRepository, PropertyOptionsRepository>();
            container.RegisterType<IPropertyOptionsService, PropertyOptionsService>();

            //container.RegisterType<IDevicesService, DevicesService>();
            //container.RegisterType<IDeviceRepository, DeviceRepository>();
            //UnityConfig.RegisterComponents();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}