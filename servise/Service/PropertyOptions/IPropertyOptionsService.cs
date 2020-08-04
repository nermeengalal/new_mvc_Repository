using Services.ViewModels.PropertyOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.PropertyOptions
{
    public interface IPropertyOptionsService
    {
        void Add(AddPropertyOptionsVm vm);
        List<PropertyOptionsVm> GetAll(int PropId);
    }
}
