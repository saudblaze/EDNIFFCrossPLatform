using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class StorageService : BaseHardwareInfo
    {
        public void GetStorage()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.Storage);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPPowerDataType obkSPPowerDataType = new SPPowerDataType();

                    Device device = new Device();
                    device.Category = ConstantData.Categories.Battery;
                    device.DeviceName = ConstantData.DeviceNames.Battery;

                    bool blnUntitled = false;

                    foreach (string items in linesArr)
                    {
                        //Power
                        if (items.ToString().Contains("Untited 2 - Data"))
                        {
                            blnUntitled = true;
                        }
                        if (blnUntitled == true && items.ToString().Contains("Capacity"))
                        {
                            device.Size = GetPropertyValue(items.ToString());
                        }
                        if (blnUntitled == true && items.ToString().Contains("Volume UUID"))
                        {
                            device.Serial = GetPropertyValue(items.ToString());
                        }
                        if (blnUntitled == true && items.ToString().Contains("Device Name"))
                        {
                            device.Manufacturer = GetPropertyValue(items.ToString());
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
