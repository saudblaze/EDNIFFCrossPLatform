using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class AudioService : BaseHardwareInfo
    {
        public bool GetSoundDevice(List<Device> devices)
        {
            bool found = false;
            var sounds = base.GetDevices(ConstantData.DevicePaths.SoundDevice);
            foreach (var item in sounds)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Audio;
                device.DeviceName = ConstantData.DeviceNames.Audio;
                device.Manufacturer = base.GetDevicePropertyValue(item, DeviceProps.SoundDevice.Manufacturer);
                device.Model = GetDevicePropertyValue(item, DeviceProps.SoundDevice.ProductName);
                //device.Serial = GetDevicePropertyValue(item, DeviceProps.SoundDevice.);
                //device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Capacity));
                //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Speed));
                device.Info1 = GetDevicePropertyValue(item, DeviceProps.SoundDevice.Name);
                //device.Info2 = GetDevicePropertyValue(item, DeviceProps.SoundDevice.Description);
                //device.Properties = item.Properties;
                device.validation = true;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Audio, ConstantData.DeviceNames.Audio));
            return found;
        }
        //public bool GetMicrophoneDevice(List<Device> devices)
        //{

        //    //code is pending for microphone 
        //    bool found = false;

        //    WaveIn s_WaveIn;

        //    var memories = base.GetDevices(ConstantData.DevicePaths.SoundDevice);
        //    foreach (var item in memories)
        //    {
        //        Device device = new Device();
        //        device.Category = ConstantData.Categories.Microphone;
        //        device.DeviceName = ConstantData.DeviceNames.Microphone;
        //        device.Manufacturer = base.GetDevicePropertyValue(item, DeviceProps.SoundDevice.Manufacturer);
        //        device.Model = GetDevicePropertyValue(item, DeviceProps.SoundDevice.ProductName);
        //        //device.Serial = GetDevicePropertyValue(item, DeviceProps.SoundDevice.);
        //        //device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Capacity));
        //        //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Speed));
        //        device.Info1 = GetDevicePropertyValue(item, DeviceProps.SoundDevice.Name);
        //        device.Info2 = GetDevicePropertyValue(item, DeviceProps.SoundDevice.Description);
        //        //device.Properties = item.Properties;
        //        devices.Add(device);
        //        found = true;
        //    }

        //    if (!found)
        //        devices.Add(GetEmptyDevice(ConstantData.Categories.Microphone, ConstantData.DeviceNames.Microphone));
        //    return found;
        //}
    }
}
