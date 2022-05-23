using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class USBService : BaseHardwareInfo
    {
        public void GetUSB()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.USB);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPPowerDataType obkSPPowerDataType = new SPPowerDataType();

                    Device device = new Device();
                    device.Category = ConstantData.Categories.Ports;
                    device.DeviceName = ConstantData.DeviceNames.USB_Port;

                    bool blnUntitled = false;

                    foreach (string items in linesArr)
                    {
                        //Power
                        if (items.ToString().Contains("Manufacturer"))
                        {
                            device.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Product ID"))
                        {
                            device.Serial = GetPropertyValue(items.ToString());
                        }
                    }

                    device.TestName = "USB";
                    device.TestLable = "USB";
                    device.TestResultLable = "Optional";
                    device.TestDone = false;

                    MacInfo.devices.Add(device);
                }
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
