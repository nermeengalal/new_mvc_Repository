using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.PropertyItems
{
    public class AddPropertyItemVm
    {
        public int ID { get; set; }
        [Display(Name = "Property Name")]
        public string Property_Name { get; set; }
        public int Category_ID { get; set; }
        public Nullable<int> Type { get; set; }
    }
}
