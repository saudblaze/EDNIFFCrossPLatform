using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class TouchpadService : BaseHardwareInfo
    {
        public bool GetPointingDevice(List<Device> devices)
        {
            bool found = false;
            var item = base.GetDevices(ConstantData.DevicePaths.PointingDevice).FirstOrDefault();
            if (item != null)
            {
                //string tmp= GetDevicePropertyValue(item, DeviceProps.PointingDevice.Caption);
                //if (!tmp.ToLower().Contains("touchpad"))
                //    continue;
                Device device = new Device();
                device.Category = ConstantData.Categories.Touchpad;
                device.DeviceName = ConstantData.DeviceNames.Touchpad;
                device.Manufacturer = GetDevicePropertyValue(item, DeviceProps.PointingDevice.Manufacturer);
                //device.Model = GetDevicePropertyValue(item, DeviceProps.PointingDevice.HardwareType);
                //device.Serial = GetDevicePropertyValue(item, DeviceProps.SoundDevice.);
                //device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Capacity));
                //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Speed));
                //device.Info1 = GetDevicePropertyValue(item, DeviceProps.SoundDevice.Name);
                device.Info2 = GetDevicePropertyValue(item, DeviceProps.PointingDevice.Description);
                //device.Properties = item.Properties;
                device.validation = true;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Touchpad, ConstantData.DeviceNames.Touchpad));

            devices.Add(GetEmptyDevice(ConstantData.Categories.Touchpad, ConstantData.DeviceNames.Trackpoint));
            return found;
        }
    }
}
