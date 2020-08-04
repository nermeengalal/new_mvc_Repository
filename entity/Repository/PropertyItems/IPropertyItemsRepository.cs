using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.PropertyItems
{
    public interface IPropertyItemsRepository
    {
        void add(Property_Items prop);
        List<Property_Items> GetAll(int CatId);
    }
}
