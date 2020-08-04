using AutoMapper;
using entity;
using Services.ViewModels.Category;
using Services.ViewModels.CategoryDeviceProperty;
using Services.ViewModels.Device;
using Services.ViewModels.DeviceCategory;
using Services.ViewModels.PropertyItems;
using Services.ViewModels.PropertyOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class MappingProfile:Profile
    {
        public static void Initialize() => Mapper.Initialize(ctr =>
                                           {
                //ctr.CreateMap<Device, asd>()
                //.ForMember(dest => dest.deviceName1, opt => opt.MapFrom(m => m.Device_Name)).
                //IgnoreAllSourcePropertiesWithAnInaccessibleSetter().
                //IgnoreAllPropertiesWithAnInaccessibleSetter();

                ctr.CreateMap<Device_Categories, DeviceCategoryVM>();

                ctr.CreateMap<Property_Options, PropertyOptionVM>();

                                               ctr.CreateMap<Property_Items, CategoryDevicePropertyVM>()
                                               .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Property_Options.Select(m => Mapper.Map<PropertyOptionVM>(m))));

                                               ctr.CreateMap<ValueOptions, Property_Value_Option>();

                                               ctr.CreateMap<PropertyValueVM, Property_Value>()
                                               .ForMember(dest => dest.Property_Value_Option, opt => opt.MapFrom(src => src.Options.Select(m => Mapper.Map<Property_Value_Option>(m))));

                                               ctr.CreateMap<DeviceVM, Device>()
                                               .ForMember(dest => dest.Property_Value, opt => opt.MapFrom(src => src.PropertyValues.Select(m => Mapper.Map<Property_Value>(m))));


                                               ctr.CreateMap<Device_Categories, AddCategoryVm>().ForMember(x => x.Category_Name, opt => opt.MapFrom(x => x.Category_Name));

                                               ctr.CreateMap<AddCategoryVm, Device_Categories>()
                                               .ForMember(x => x.Category_Name, opt => opt.MapFrom(x => x.Category_Name));

                                               ctr.CreateMap<CategoryVm, Device_Categories>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter()
                                               .IgnoreAllPropertiesWithAnInaccessibleSetter();

                                               ctr.CreateMap<Device_Categories, CategoryVm>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter().
                                               IgnoreAllPropertiesWithAnInaccessibleSetter();

                //Property ITems
                ctr.CreateMap<Property_Items, AddPropertyItemVm>()
                                               .ForMember(x => x.Property_Name, opt => opt.MapFrom(x => x.Property_Name));

                                               ctr.CreateMap<AddPropertyItemVm, Property_Items>()
                                               .ForMember(x => x.Property_Name, opt => opt.MapFrom(x => x.Property_Name));

                                               ctr.CreateMap<PropertyItemVm, Property_Items>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter()
                                               .IgnoreAllPropertiesWithAnInaccessibleSetter();

                                               ctr.CreateMap<Property_Items, PropertyItemVm>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter().
                                               IgnoreAllPropertiesWithAnInaccessibleSetter();

                //Property options
                ctr.CreateMap<Property_Options, AddPropertyOptionsVm>()
                                               .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name));

                                               ctr.CreateMap<AddPropertyOptionsVm, Property_Options>()
                                               .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name));

                                               ctr.CreateMap<PropertyOptionsVm, Property_Options>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter()
                                               .IgnoreAllPropertiesWithAnInaccessibleSetter();

                                               ctr.CreateMap<Property_Options, PropertyOptionsVm>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter().
                                               IgnoreAllPropertiesWithAnInaccessibleSetter();


                                               ctr.CreateMap<Device_Categories, DeviceCategoryVM>();
                                               ctr.CreateMap<Property_Value, PropertyValueVM>();
                                               ctr.CreateMap<Device, DeviceAndCategoryVM>()
                                               .ForMember(dest => dest.Device_Category, opt => opt.MapFrom(m => Mapper.Map<DeviceCategoryVM>(m.Device_Categories)));

                                           });
    }
}
