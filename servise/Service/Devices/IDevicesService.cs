using Entity.DBEntities;
using Services.ViewModels.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service.Devices
{
    public interface IDevicesService
    {
        IEnumerable<DeviceAndCategoryVM> GetAll();
        IEnumerable<DeviceDetails_Result> GetDeviceDetails(int DeviceId);
    }
}
