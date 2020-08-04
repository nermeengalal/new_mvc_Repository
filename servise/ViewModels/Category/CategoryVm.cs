using Services.ViewModels.PropertyItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.Category
{
    public class CategoryVm
    {
        public int ID { get; set; }
        public string Category_Name { get; set; }
        public virtual ICollection<PropertyItemVm> Property_Items { get; set; }

    }
}
