using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class CameraService : BaseHardwareInfo
    {
        public void GetCamera()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Webcam;
                device.DeviceName = ConstantData.DeviceNames.Webcam;
                device.TestName = "Camera";
                device.TestLable = "Camera";
                device.TestResultLable = "Optional";
                device.TestDone = false;

                string strtemp = GetInfoString(ConstantData.DevicePaths.Camera);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string items in linesArr)
                    {
                        if (items.ToString().Contains("Model ID"))
                        {
                            device.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Unique ID"))
                        {
                            device.Serial = GetPropertyValue(items.ToString());
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
