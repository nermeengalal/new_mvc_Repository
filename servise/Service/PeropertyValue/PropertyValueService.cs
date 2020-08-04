using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using entity;
using Entity.Repository.PropertyValue;
using Services.ViewModels.CategoryDeviceProperty;
using Services.ViewModels.Device;
using Services.ViewModels.DeviceCategory;

namespace Services.Service.PeropertyValue
{
    public class PropertyValueService : IPropertyValueService
    {
        private IPropertyValueRepository _propertyValueRepository;
        public PropertyValueService(IPropertyValueRepository propertyValueRepository)
        {
            _propertyValueRepository = propertyValueRepository;
        }
        public int Add(DeviceVM model)
        {
            var entity = Mapper.Map<Device>(model);
            return _propertyValueRepository.Add(entity);
        }

        public IEnumerable<DeviceCategoryVM> GetAllDeviceCategories()
        {
            var model = _propertyValueRepository.GetAllDeviceCategories();
            return model.Select(m => Mapper.Map<DeviceCategoryVM>(m)).ToList();
        }

        public IEnumerable<CategoryDevicePropertyVM> GetCategoryDeviceProperty(int DeviceCategoriesId)
        {
            var model = _propertyValueRepository.GetCategoryDeviceProperty(DeviceCategoriesId);
            return model.Select(m => Mapper.Map<CategoryDevicePropertyVM>(m)).ToList();
        }
    }
}
