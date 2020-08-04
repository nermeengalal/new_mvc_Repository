using AutoMapper;
using entity;
using Entity.Repository.PropertyItems;
using Services.ViewModels.PropertyItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.PropertyItems
{
    public class PropertyItemsService : IPropertyIetmsService
    {
        private IPropertyItemsRepository _propertyItemsRepository;
        public PropertyItemsService(IPropertyItemsRepository propertyItemsRepository)
        {
            _propertyItemsRepository = propertyItemsRepository;
        }

        public void add(AddPropertyItemVm vm)
        {
            var entity = Mapper.Map<Property_Items>(vm);
            _propertyItemsRepository.add(entity);
        }

        public List<PropertyItemVm> GetAll(int CatId)
        {
            var entities = _propertyItemsRepository.GetAll(CatId);
            var vms = entities.ToList().Select(m => Mapper.Map<PropertyItemVm>(m)).ToList();
            return vms;
        }
    }
}
