using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.Device
{
    public class DeviceVM
    {
        public string Device_Name { get; set; }
        public int Category_ID { get; set; }
        public  List<PropertyValueVM> PropertyValues { get; set; }
    }

    public class PropertyValueVM
    {
        public int Property_ID { get; set; }
        public string Value { get; set; }
        public List<ValueOptions> Options { get; set; }
    }

    public class ValueOptions
    {
        public int Property_Option_ID { get; set; }
    }



}
