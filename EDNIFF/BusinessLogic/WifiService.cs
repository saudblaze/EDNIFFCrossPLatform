using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class WifiService : BaseHardwareInfo
    {
        public void GetWifi()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.WIFI);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPPowerDataType obkSPPowerDataType = new SPPowerDataType();

                    Device device = new Device();
                    device.Category = ConstantData.Categories.Network;
                    device.DeviceName = ConstantData.DeviceNames.Wifi;

                    foreach (string items in linesArr)
                    {
                        //Power
                        if (items.ToString().Contains("Cart Type"))
                        {
                            device.Model = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Firmware Version"))
                        {
                            device.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("MAC Address"))
                        {
                            device.Serial = GetPropertyValue(items.ToString());
                        }
                    }

                    MacInfo.devices.Add(device);
                }
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
