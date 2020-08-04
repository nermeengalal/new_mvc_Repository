using AutoMapper;
using entity;
using Entity.Repository.PropertyOptions;
using Services.ViewModels.PropertyOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.PropertyOptions
{
    public class PropertyOptionsService : IPropertyOptionsService
    {
        private IPropertyOptionsRepository _propertyOptionsRepository;
        public PropertyOptionsService(IPropertyOptionsRepository propertyOptionsRepository)
        {
            _propertyOptionsRepository = propertyOptionsRepository;
        }

        public void Add(AddPropertyOptionsVm vm)
        {
            var en = Mapper.Map<Property_Options>(vm);
            _propertyOptionsRepository.Add(en);

        }

        public List<PropertyOptionsVm> GetAll(int PropId)
        {
            var entities = _propertyOptionsRepository.GetAll(PropId);
            var vms = entities.ToList().
                Select(m => Mapper.Map<PropertyOptionsVm>(m)).ToList();
            return vms;
        }
    }
}
