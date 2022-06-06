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
                Device device = new Device();
                device.Category = ConstantData.Categories.Storage;
                device.DeviceName = ConstantData.DeviceNames.Storage;
                device.TestName = "Storage";
                device.TestLable = "Storage";
                device.TestResultLable = "Optional";
                device.TestDone = false;


                string strtemp = GetInfoString(ConstantData.DevicePaths.Storage);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPPowerDataType obkSPPowerDataType = new SPPowerDataType();

                    bool blnUntitled = false;

                    foreach (string items in linesArr)
                    {
                        //Power
                        if (items.ToString().Contains("Untitled 2 - Data"))
                        {
                            blnUntitled = true;
                        }
                        if (items.ToString().Contains("Untitled 2:"))
                        {
                            blnUntitled = false;
                        }
                        if (blnUntitled == true && items.ToString().Contains("Capacity"))
                        {
                            device.Size = GetPropertyValue(items.ToString());

                            string strProperty = GetPropertyValue(items.ToString());
                            string[] strValueArr = strProperty.Split('(');
                            string strValue = strValueArr[1].Trim();
                            MacInfo.StorageSize = strValue;

                            //MacInfo.StorageSize = GetPropertyValue(items.ToString());
                        }
                        if (blnUntitled == true && items.ToString().Contains("Volume UUID"))
                        {
                            device.Serial = GetPropertyValue(items.ToString());
                        }
                        if (blnUntitled == true && items.ToString().Contains("Device Name"))
                        {
                            device.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (blnUntitled == true && items.ToString().Contains("Medium Type"))
                        {
                            MacInfo.StorageType = GetPropertyValue(items.ToString());
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
