using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class SDCardService : BaseHardwareInfo
    {
        public void GetSDCard()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Ports;
                device.DeviceName = ConstantData.DeviceNames.SDCardPort;
                device.TestName = "SDCard";
                device.TestLable = "SDCard";
                device.TestResultLable = "Optional";
                device.TestDone = false;

                string strtemp = GetInfoString(ConstantData.DevicePaths.CardReader);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string items in linesArr)
                    {
                        if (items.ToString().Contains("Serial Number"))
                        {
                            device.Serial = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Product ID"))
                        {
                            device.Model = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Vendor ID"))
                        {
                            device.Manufacturer = GetPropertyValue(items.ToString());
                        }
                    }
                    device.deviceStatus = DeviceStatus.NotTested;

                }
                else
                {
                    device.deviceStatus = DeviceStatus.NotPresent;
                }                

                MacInfo.devices.Add(device);

            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
