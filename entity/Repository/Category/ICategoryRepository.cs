
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.Category
{
    public interface ICategoryRepository
    {
        void add(Device_Categories model);
        Device_Categories get(int id);
        List<Device_Categories> GetAll();
    }
}
