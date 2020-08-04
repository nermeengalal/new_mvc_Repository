using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.PropertyValue
{
    public interface IPropertyValueRepository
    {
        int Add(Device model);
        IEnumerable<Device_Categories> GetAllDeviceCategories();
        IEnumerable<Property_Items> GetCategoryDeviceProperty(int DeviceCategoriesId);
    }
}
