using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.PropertyOptions
{
    public interface IPropertyOptionsRepository
    {
        void Add(Property_Options entity);
        List<Property_Options> GetAll(int PropId);
    }
}
