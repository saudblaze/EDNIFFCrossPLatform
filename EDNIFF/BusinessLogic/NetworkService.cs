using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class NetworkService : BaseHardwareInfo
    {
        public void GetNetwork()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.Network);
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
                        if (items.ToString().Contains("Type:"))
                        {
                            device.Model = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Hardware"))
                        {
                            device.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("IPv4 Addresses"))
                        {
                            device.Info1 = GetPropertyValue(items.ToString());
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
