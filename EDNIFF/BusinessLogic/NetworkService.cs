using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class NetworkService : BaseHardwareInfo
    {
        public bool GetNetworkDevices(List<Device> devices)
        {
            bool found = false;
            bool lan = false;
            bool wifi = false;
            bool bluetooth = false;
            bool infra = false;
            var adapters = base.GetDevices(ConstantData.DevicePaths.NetworkAdapter);
            NetworkInterface[] networkCards = NetworkInterface.GetAllNetworkInterfaces();
            var x = networkCards[0].Name;
            foreach (var item in adapters)
            {
                found = false;
                string _netConnectionID = GetDevicePropertyValue(item, DeviceProps.NetworkAdapter.NetConnectionID).ToLower();
                if (string.IsNullOrEmpty(_netConnectionID))
                    continue;
                ConstantData.DeviceNames devicename = ConstantData.DeviceNames.Unknow;
                if (_netConnectionID.ToUpper() == x.ToUpper() && !_netConnectionID.Contains("default switch"))
                {
                    if (GetDevicePropertyValue(item, DeviceProps.NetworkAdapter.PNPDeviceID).ToLower().Contains("usb"))
                        continue;
                    devicename = ConstantData.DeviceNames.LAN;
                    lan = true;
                    found = true;
                }
                else if (_netConnectionID.Contains("wi-fi") || _netConnectionID.Contains("wifi") || _netConnectionID.Contains("wireless"))
                {
                    devicename = ConstantData.DeviceNames.Wifi;
                    wifi = true;
                    found = true;
                }
                else if (_netConnectionID.Contains("bluetooth"))
                {
                    devicename = ConstantData.DeviceNames.Bluetooth;
                    bluetooth = true;
                    found = true;
                }
                else if (_netConnectionID.Contains("infra"))
                {
                    devicename = ConstantData.DeviceNames.Infrared;
                    infra = false;
                    found = true;
                }
                if (found)
                {
                    Device device = new Device();
                    device.Category = ConstantData.Categories.Network;
                    device.Speed = GetDevicePropertyValue(item, DeviceProps.NetworkAdapter.NetConnectionID);
                    device.Manufacturer = GetDevicePropertyValue(item, DeviceProps.NetworkAdapter.Manufacturer);
                    device.Model = GetDevicePropertyValue(item, DeviceProps.NetworkAdapter.ProductName);
                    if (devicename == ConstantData.DeviceNames.Wifi)
                    {
                        device.Serial = GetDevicePropertyValue(item, DeviceProps.NetworkAdapter.MACAddress).Replace(":", "");
                        device.Info1 = GetRadioTypeSupported();
                    }
                    else
                    {
                        device.Info1 = GetDevicePropertyValue(item, DeviceProps.NetworkAdapter.MACAddress).Replace(":", "");
                    }
                    device.Info2 = GetDevicePropertyKeyValue(item, ConstantData.DeviceNames.LAN, DeviceProps.NetworkAdapter.NetConnectionStatus);
                    device.DeviceName = devicename;
                    device.validation = true;
                    devices.Add(device);
                }
                found = true;
            }
            if (!lan)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Network, ConstantData.DeviceNames.LAN));
            if (!wifi)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Network, ConstantData.DeviceNames.Wifi));
            if (!bluetooth)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Network, ConstantData.DeviceNames.Bluetooth));
            if (!infra)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Network, ConstantData.DeviceNames.Infrared));
            //need to add devices it empty
            return found;
        }


        public string GetRadioTypeSupported()
        {
            string strReturn = string.Empty;

            string strScript = "NETSH WLAN SHOW DRIVE";
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(strScript);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> results = pipeline.Invoke();
            runspace.Close();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject pSObject in results)
            {
                stringBuilder.AppendLine(pSObject.ToString());
            }

            string strtemp = stringBuilder.ToString();
            string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string items in linesArr)
            {
                if (items.ToString().Contains("Radio types supported"))
                {
                    string[] itemsArr = items.Split(new string[] { ":" }, StringSplitOptions.None);
                    if (itemsArr != null)
                    {
                        strReturn = itemsArr[1].ToString().TrimStart();
                    }
                }
            }
            return strReturn;
        }
    }
}
