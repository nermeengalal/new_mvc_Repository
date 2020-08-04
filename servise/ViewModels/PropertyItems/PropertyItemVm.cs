using Services.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.PropertyItems
{
    public class PropertyItemVm
    {
        public int ID { get; set; }
        public string Property_Name { get; set; }
        public int Category_ID { get; set; }
        public Nullable<int> Type { get; set; }

        public virtual CategoryVm Device_Categories { get; set; }
        //public virtual ICollection<Property_Options> Property_Options { get; set; }

    }
}
