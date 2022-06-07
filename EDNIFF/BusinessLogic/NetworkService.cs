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
                Device device = new Device();
                device.Category = ConstantData.Categories.Network;
                device.DeviceName = ConstantData.DeviceNames.Wifi;
                device.TestName = "Wifi";
                device.TestLable = "Wifi";
                device.TestResultLable = "Optional";
                device.TestDone = false;

                string strtemp = GetInfoString(ConstantData.DevicePaths.Network);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPPowerDataType obkSPPowerDataType = new SPPowerDataType();

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
                        if (items.ToString().Contains("MAC Address"))
                        {
                            MacInfo.MACAddress = GetPropertyValue(items.ToString());
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

        public void GetEthernet()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Network;
                device.DeviceName = ConstantData.DeviceNames.LAN;
                device.TestName = "LanPort";
                device.TestLable = "LanPort";
                device.TestResultLable = "Optional";
                device.TestDone = false;

                string strtemp = GetInfoString(ConstantData.DevicePaths.Ethernet);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPPowerDataType obkSPPowerDataType = new SPPowerDataType();

                    device.deviceStatus = DeviceStatus.NotTested;

                    foreach (string items in linesArr)
                    {
                        //right now dont have model with ethernet 
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
