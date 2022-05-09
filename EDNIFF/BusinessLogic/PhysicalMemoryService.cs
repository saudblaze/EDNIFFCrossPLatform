using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class PhysicalMemoryService : BaseHardwareInfo
    {
        public bool GetPhysicalMemory(List<Device> devices)
        {
            bool found = false;
            var memories = base.GetDevices(ConstantData.DevicePaths.PhysicalMemory);
            double ramsize = 0;
            PublicVariables.RAMSize = 0;
            foreach (var item in memories)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.RAM;
                device.DeviceName = ConstantData.DeviceNames.RAM;
                device.Manufacturer = base.GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Manufacturer);
                device.Model = GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.PartNumber);
                device.Serial = GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.SerialNumber);
                double.TryParse(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Capacity), out double rmsz);
                device.Size = UtilityHelper.GetDataSize(rmsz);
                ramsize += rmsz;
                device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Speed));
                device.Info1 = GetDevicePropertyKeyValue(item, ConstantData.DeviceNames.RAM, DeviceProps.PhysicalMemory.SMBIOSMemoryType);
                device.Info2 = GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.DeviceLocator);
                device.Caption = GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Caption);
                device.Description = GetDevicePropertyFormFactorValue(item, DeviceProps.PhysicalMemory.FormFactor);
                device.validation = true;
                //device. = item.Properties;
                devices.Add(device);
                found = true;
            }
            PublicVariables.RAMSize = ramsize;
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.RAM, ConstantData.DeviceNames.RAM));
            return found;
        }
    }
}
