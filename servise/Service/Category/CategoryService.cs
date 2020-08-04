using AutoMapper;
using entity;
using Entity.Repository.Category;
using Services.ViewModels.Category;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service.Category
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void add(AddCategoryVm vm)
        {
            var entity = Mapper.Map<Device_Categories>(vm);
            _categoryRepository.add(entity);
        }

        public CategoryVm Get(int id)
        {
            var entity = _categoryRepository.get(id);
            var vm = Mapper.Map<CategoryVm>(entity);
            return vm;
        }

        public List<CategoryVm> GetAll()
        {
            var entities = _categoryRepository.GetAll();
            var Vms = entities.ToList()
                .Select(m => Mapper.Map<CategoryVm>(m)).ToList();
            return Vms;
        }
    }
}
