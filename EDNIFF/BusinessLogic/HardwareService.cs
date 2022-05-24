using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;

namespace EDNIFF.BusinessLogic
{
    class HardwareService : BaseHardwareInfo
    {
        public void GetHardware()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Processor;
                device.DeviceName = ConstantData.DeviceNames.Processor;
                device.Manufacturer = "Apple";

                string strtemp = GetInfoString(ConstantData.DevicePaths.Hardware);
                if (string.IsNullOrEmpty(strtemp))
                {
                    return;
                }
                string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                SPHardwareDataType sPHardwareDataType = new SPHardwareDataType();
                foreach (string items in linesArr)
                {

                    if (items.ToString().Contains("Model Name"))
                    {
                        sPHardwareDataType.ModelName = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Model Identifier"))
                    {
                        sPHardwareDataType.ModelIdentifier = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Processor Name"))
                    {
                        sPHardwareDataType.ProcessorName = GetPropertyValue(items.ToString());
                        device.Model = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Processor Speed"))
                    {
                        sPHardwareDataType.ProcessorSpeed = GetPropertyValue(items.ToString());
                        device.Speed = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Number of Processors"))
                    {
                        sPHardwareDataType.NumberOfProcessors = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Total Number of Cores"))
                    {
                        sPHardwareDataType.TotalNumberOfCores = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("L2 Cache"))
                    {
                        sPHardwareDataType.L2Cache = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("L3 Cache"))
                    {
                        sPHardwareDataType.L3Cache = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Hyper-Threading Technology"))
                    {
                        sPHardwareDataType.HyperThreadingTechnology = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Memory"))
                    {
                        sPHardwareDataType.Memory = GetPropertyValue(items.ToString());
                        device.Size = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("System Firmware Version"))
                    {
                        sPHardwareDataType.SystemFirmwareVersion = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("SMC Version"))
                    {
                        sPHardwareDataType.SMCVersion = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Serial Number"))
                    {
                        sPHardwareDataType.SerialNumber = GetPropertyValue(items.ToString());
                        device.Serial = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Hardware UUID"))
                    {
                        sPHardwareDataType.HardwareUUID = GetPropertyValue(items.ToString());
                    }
                    if (items.ToString().Contains("Provisioning UDID"))
                    {
                        sPHardwareDataType.ProvisioningUDID = GetPropertyValue(items.ToString());
                    }
                }

                //MacInfo.Hardware = sPHardwareDataType;
                MacInfo.devices.Add(device);

                if (!string.IsNullOrEmpty(sPHardwareDataType.SystemFirmwareVersion) && !string.IsNullOrEmpty(sPHardwareDataType.SMCVersion) && !string.IsNullOrEmpty(sPHardwareDataType.ModelIdentifier))
                {
                    Device deviceCMOS = new Device();
                    deviceCMOS.Category = ConstantData.Categories.MotherBoard;
                    deviceCMOS.DeviceName = ConstantData.DeviceNames.MotherBoard;
                    deviceCMOS.Manufacturer = "Apple";
                    deviceCMOS.Model = sPHardwareDataType.SMCVersion;
                    deviceCMOS.Serial = sPHardwareDataType.SystemFirmwareVersion;
                    deviceCMOS.Info1 = sPHardwareDataType.ModelIdentifier;
                    deviceCMOS.Info2 = sPHardwareDataType.ModelName;

                    deviceCMOS.TestName = "CMOS";
                    deviceCMOS.TestLable = "CMOS";
                    deviceCMOS.TestResultLable = "Optional";
                    deviceCMOS.TestDone = false;                    
                    
                    MacInfo.devices.Add(deviceCMOS);
                }

            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }

        public void GetDiscBurning()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Other;
                device.DeviceName = ConstantData.DeviceNames.CDROMDrive;
                device.TestName = "Optical";
                device.TestLable = "Optical";
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

        public void GetKeyboard()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Other;
                device.DeviceName = ConstantData.DeviceNames.Keyboard;
                device.TestName = "Keyboard";
                device.TestLable = "Keyboard";
                device.TestResultLable = "Optional";
                device.TestDone = false;
                device.deviceStatus = DeviceStatus.NotTested;
                
                MacInfo.devices.Add(device);
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }

        public void GetTouchpad()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Other;
                device.DeviceName = ConstantData.DeviceNames.Touchpad;
                device.TestName = "Touchpad";
                device.TestLable = "Touchpad";
                device.TestResultLable = "Optional";
                device.TestDone = false;
                device.deviceStatus = DeviceStatus.NotTested;

                MacInfo.devices.Add(device);
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }

        public void GetBiometric()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Ports;
                device.DeviceName = ConstantData.DeviceNames.BiometricSensorPort;
                device.TestName = "Biometric";
                device.TestLable = "Biometric";
                device.TestResultLable = "Optional";
                device.TestDone = false;
                device.deviceStatus = DeviceStatus.NotTested;

                MacInfo.devices.Add(device);
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }

        public void GetSmartCard()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Ports;
                device.DeviceName = ConstantData.DeviceNames.SmartCard_Port;
                device.TestName = "SmartCard";
                device.TestLable = "SmartCard";
                device.TestResultLable = "Optional";
                device.TestDone = false;
                device.deviceStatus = DeviceStatus.NotTested;

                MacInfo.devices.Add(device);
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }

        public void GetPortTest()
        {
            try
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Ports;
                device.DeviceName = ConstantData.DeviceNames.Ports;
                device.TestName = "PortTest";
                device.TestLable = "PortTest";
                device.TestResultLable = "Optional";
                device.TestDone = false;
                device.deviceStatus = DeviceStatus.NotTested;

                MacInfo.devices.Add(device);
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
