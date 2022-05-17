using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class BluetoothService : BaseHardwareInfo
    {
        public void GetBluetooth()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Network;
                device.DeviceName = ConstantData.DeviceNames.Bluetooth;
                

                string strtemp = GetInfoString(ConstantData.DevicePaths.Bluetooth);

                string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                
                foreach (string items in linesArr)
                {

                    if (items.ToString().Contains("Manufacturer: "))
                    {
                        device.Manufacturer  = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Device Type (Complete)"))
                    {
                        device.Model = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Chipset"))
                    {
                        device.Serial = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Name:"))
                    {
                        device.Info1 = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Firmware Version"))
                    {
                        device.Info2 = GetPropertyValue(items.ToString());
                    }

                }

                
                MacInfo.devices.Add(device);

            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
