using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class ProcessorService : BaseHardwareInfo
    {


        public bool GetProcessorInfo(List<Device> devices)
        {
            bool found = false;

            var processors = GetDevices(ConstantData.DevicePaths.Processor);

            foreach (var item in processors)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Processor;
                device.DeviceName = ConstantData.DeviceNames.Processor;
                device.Manufacturer = GetDevicePropertyValue(item, DeviceProps.Processor.Manufacturer);
                device.Model = GetDevicePropertyValue(item, DeviceProps.Processor.Name);
                device.Serial = GetDevicePropertyValue(item, DeviceProps.Processor.ProcessorId);
                device.Size = GetDevicePropertyValue(item, DeviceProps.Processor.NumberOfCores);
                try
                {
                    string[] subs = device.Model.Split('@');
                    device.Speed = subs[1].Replace(" ", "");

                }
                catch (IndexOutOfRangeException)
                {
                    device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.Processor.CurrentClockSpeed));

                }
                //device.Info1 = GetDevicePropertyValue(item, DeviceProps.Processor.Description);
                device.Caption = GetDevicePropertyValue(item, DeviceProps.Processor.Name);

                string procename = GetDevicePropertyValue(item, DeviceProps.Processor.Name);
                var tmp = procename.Split('-');
                if (tmp.Length > 1)
                {
                    if (tmp[0].IndexOf(' ') > 0)
                        tmp[0] = tmp[0].Substring(tmp[0].Trim().LastIndexOf(' '));

                    if (tmp[1].Length > 1)
                    {
                        tmp[1] = tmp[1].Trim().Substring(0, 2);
                        if (!(tmp[1] == "10" || tmp[1] == "11" || tmp[1] == "12"))
                            tmp[1] = tmp[1].Trim().Substring(0, 1);
                    }
                    device.Info1 = (tmp[0].ToLower() + " " + tmp[1] + "th Gen").Trim();
                }
                device.validation = true;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Processor, ConstantData.DeviceNames.Processor));
            return found;
        }
    }
}
