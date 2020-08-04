using Services.ViewModels.CategoryDeviceProperty;
using Services.ViewModels.Device;
using Services.ViewModels.DeviceCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.PeropertyValue
{
    public interface IPropertyValueService
    {
        int Add(DeviceVM model);
        IEnumerable<DeviceCategoryVM> GetAllDeviceCategories();
        IEnumerable<CategoryDevicePropertyVM> GetCategoryDeviceProperty(int DeviceCategoriesId);
    }
}
