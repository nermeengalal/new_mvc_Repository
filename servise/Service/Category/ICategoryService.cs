using Services.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.Category
{
    public interface ICategoryService
    {
        void add(AddCategoryVm vm);
        CategoryVm Get(int id);
        List<CategoryVm> GetAll();
    }
}
