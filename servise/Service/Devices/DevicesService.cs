using AutoMapper;
using Entity.DBEntities;
using Entity.Repository.Devices;
using Services.ViewModels.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.Devices
{
    public class DevicesService : IDevicesService
    {
        private IDeviceRepository _device;
        public DevicesService(IDeviceRepository device)
        {
            _device = device;
        }
        public IEnumerable<DeviceAndCategoryVM> GetAll()
        {
            var model = _device.GetAll();
            return model.Select(m => Mapper.Map<DeviceAndCategoryVM>(m)).ToList();
        }

        public IEnumerable<DeviceDetails_Result> GetDeviceDetails(int DeviceId)
        {
            return _device.GetDeviceDetails(DeviceId);
        }
    }
}
