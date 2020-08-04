using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity.Repository.PropertyValue
{
    public class PropertyValueRepository: IPropertyValueRepository
    {
        protected readonly TASKEntities _context;
        public PropertyValueRepository(TASKEntities context)
        {
            _context = context;
        }

        public int Add(Device model)
        {
            _context.Devices.Add(model);
            return _context.SaveChanges();
        }

        public IEnumerable<Device_Categories> GetAllDeviceCategories()
        {
            return _context.Device_Categories.ToList();
        }

        public IEnumerable<Property_Items> GetCategoryDeviceProperty(int DeviceCategoriesId)
        {
            return _context.Property_Items.Where(m=>m.Category_ID== DeviceCategoriesId).Include(m => m.Property_Options).ToList();
        }
    }
}
