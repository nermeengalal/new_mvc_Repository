using Services.ViewModels.PropertyItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.PropertyItems
{
    public interface IPropertyIetmsService
    {
        void add(AddPropertyItemVm vm);
        List<PropertyItemVm> GetAll(int CatId);
    }
}
