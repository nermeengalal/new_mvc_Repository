using Services.ViewModels.DeviceCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.Device
{
    public class DeviceAndCategoryVM
    {
        public int id { get; set; }

        [Display(Name = "Device Name")]
        public string Device_Name { get; set; }
        public DeviceCategoryVM Device_Category { get; set; }
    }
}
