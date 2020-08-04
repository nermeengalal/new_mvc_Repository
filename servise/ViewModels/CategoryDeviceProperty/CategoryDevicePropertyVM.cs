using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.CategoryDeviceProperty
{
    public class CategoryDevicePropertyVM
    {
        public int ID { get; set; }
        public string Property_Name { get; set; }
        public int Type { get; set; }

        public List<PropertyOptionVM> Options { get; set; }
    }

    public class PropertyOptionVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
