using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class BatteryService : BaseHardwareInfo
    {
        public void GetBattery()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.Displays);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPPowerDataType obkSPPowerDataType = new SPPowerDataType();

                    Device device = new Device();
                    device.Category = ConstantData.Categories.Battery;
                    device.DeviceName = ConstantData.DeviceNames.Battery;


                    foreach (string items in linesArr)
                    {
                        //Power
                        if (items.ToString().Contains("Manufacturer"))
                        {
                            obkSPPowerDataType.Manufacturer = GetPropertyValue(items.ToString());
                            device.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Device Name"))
                        {
                            obkSPPowerDataType.DeviceName = GetPropertyValue(items.ToString());
                            device.Serial = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Pack Lot Code"))
                        {
                            obkSPPowerDataType.PackLotCode = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("PCB Lot Code"))
                        {
                            obkSPPowerDataType.PCBLotCode = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Firmware Version"))
                        {
                            obkSPPowerDataType.FirmwareVersion = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Hardware Revision"))
                        {
                            obkSPPowerDataType.HardwareRevision = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Cell Revision"))
                        {
                            obkSPPowerDataType.CellRevision = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Fully Charged"))
                        {
                            obkSPPowerDataType.FullyCharged = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Charging"))
                        {
                            obkSPPowerDataType.Charging = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Full Charge Capacity"))
                        {
                            obkSPPowerDataType.FullChargeCapacity = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("State of Charge"))
                        {
                            obkSPPowerDataType.StateOfCharge = GetPropertyValue(items.ToString());
                            device.Info1 = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Cycle Count"))
                        {
                            obkSPPowerDataType.CycleCount = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Condition"))
                        {
                            obkSPPowerDataType.Condition = GetPropertyValue(items.ToString());
                            device.Info2 = GetPropertyValue(items.ToString());
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
