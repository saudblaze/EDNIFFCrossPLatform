using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class KeyboardService : BaseHardwareInfo
    {
        public bool GetKeyboardDevice(List<Device> devices)
        {
            bool found = false;
            var keyboards = base.GetDevices(ConstantData.DevicePaths.Keyboard);
            var keydevice = keyboards.FirstOrDefault();
            if (keydevice != null)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Keyboard;
                device.DeviceName = ConstantData.DeviceNames.Keyboard;
                device.Manufacturer = base.GetDevicePropertyValue(keydevice, DeviceProps.Keyboard.Caption);
                device.Model = GetDevicePropertyValue(keydevice, DeviceProps.Keyboard.NumberOfFunctionKeys);
                //device.Serial = GetDevicePropertyValue(item, DeviceProps.SoundDevice.);
                //device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Capacity));
                //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Speed));
                //device.Info1 = GetDevicePropertyValue(item, DeviceProps.SoundDevice.Name);
                device.Info2 = GetDevicePropertyValue(keydevice, DeviceProps.Keyboard.Description);

                //device.Properties = item.Properties;
                device.validation = true;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Keyboard, ConstantData.DeviceNames.Keyboard));
            return found;
        }
    }
}
