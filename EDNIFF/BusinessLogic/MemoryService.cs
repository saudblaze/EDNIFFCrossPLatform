using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class MemoryService : BaseHardwareInfo
    {
        public void GetMemory()
        {
            try
            {
                
                


                string strtemp = GetInfoString(ConstantData.DevicePaths.Memory);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPMemoryDataType SPMemoryDataType = new SPMemoryDataType();

                    bool blnBank0 = false;
                    bool blnBank1 = false;


                    foreach (string items in linesArr)
                    {

                        if (items.ToString().Contains("ECC:"))
                        {
                            SPMemoryDataType.ECC = GetPropertyValue(items.ToString());
                        }

                        if (items.ToString().Contains("Upgradeable Memory"))
                        {
                            SPMemoryDataType.UpgradeableMemory = GetPropertyValue(items.ToString());
                        }

                        if (items.ToString().Contains("BANK 0"))
                        {
                            blnBank0 = true;
                            blnBank1 = false;
                            SPMemoryDataType.Bank0 = new Bank0();
                        }

                        if (items.ToString().Contains("BANK 1"))
                        {
                            blnBank1 = true;
                            blnBank0 = false;
                            SPMemoryDataType.Bank1 = new Bank1();
                        }

                        //blnBank0
                        if (blnBank0 == true && items.ToString().Contains("Size"))
                        {
                            SPMemoryDataType.Bank0.Size = GetPropertyValue(items.ToString());
                        }
                        if (blnBank0 == true && items.ToString().Contains("Type"))
                        {
                            SPMemoryDataType.Bank0.Type = GetPropertyValue(items.ToString());
                        }
                        if (blnBank0 == true && items.ToString().Contains("Speed"))
                        {
                            SPMemoryDataType.Bank0.Speed = GetPropertyValue(items.ToString());
                        }
                        if (blnBank0 == true && items.ToString().Contains("Status"))
                        {
                            SPMemoryDataType.Bank0.Status = GetPropertyValue(items.ToString());
                        }
                        if (blnBank0 == true && items.ToString().Contains("Manufacturer"))
                        {
                            SPMemoryDataType.Bank0.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (blnBank0 == true && items.ToString().Contains("Part Number"))
                        {
                            SPMemoryDataType.Bank0.PartNumber = GetPropertyValue(items.ToString());
                        }
                        if (blnBank0 == true && items.ToString().Contains("Serial Number"))
                        {
                            SPMemoryDataType.Bank0.SerialNumber = GetPropertyValue(items.ToString());
                        }


                        //blnBank1
                        if (blnBank1 == true && items.ToString().Contains("Size"))
                        {
                            SPMemoryDataType.Bank1.Size = GetPropertyValue(items.ToString());
                        }
                        if (blnBank1 == true && items.ToString().Contains("Type"))
                        {
                            SPMemoryDataType.Bank1.Type = GetPropertyValue(items.ToString());
                        }
                        if (blnBank1 == true && items.ToString().Contains("Speed"))
                        {
                            SPMemoryDataType.Bank1.Speed = GetPropertyValue(items.ToString());
                        }
                        if (blnBank1 == true && items.ToString().Contains("Status"))
                        {
                            SPMemoryDataType.Bank1.Status = GetPropertyValue(items.ToString());
                        }
                        if (blnBank1 == true && items.ToString().Contains("Manufacturer"))
                        {
                            SPMemoryDataType.Bank1.Manufacturer = GetPropertyValue(items.ToString());
                        }
                        if (blnBank1 == true && items.ToString().Contains("Part Number"))
                        {
                            SPMemoryDataType.Bank1.PartNumber = GetPropertyValue(items.ToString());
                        }
                        if (blnBank1 == true && items.ToString().Contains("Serial Number"))
                        {
                            SPMemoryDataType.Bank1.SerialNumber = GetPropertyValue(items.ToString());
                        }
                    }

                    if (SPMemoryDataType.Bank0 != null)
                    {
                        Device device = new Device();
                        device.Category = ConstantData.Categories.RAM;
                        device.DeviceName = ConstantData.DeviceNames.RAM;
                        device.Manufacturer = SPMemoryDataType.Bank0.Manufacturer;
                        device.Model = SPMemoryDataType.Bank0.Type;
                        device.Serial = SPMemoryDataType.Bank0.SerialNumber;
                        device.Size = SPMemoryDataType.Bank0.Size;
                        device.Speed = SPMemoryDataType.Bank0.Speed;
                        device.Info1 = "";
                        device.Info2 = "";
                        MacInfo.devices.Add(device);
                    }
                    if (SPMemoryDataType.Bank1 != null)
                    {
                        Device device = new Device();
                        device.Category = ConstantData.Categories.RAM;
                        device.DeviceName = ConstantData.DeviceNames.RAM;
                        device.Manufacturer = SPMemoryDataType.Bank1.Manufacturer;
                        device.Model = SPMemoryDataType.Bank1.Type;
                        device.Serial = SPMemoryDataType.Bank1.SerialNumber;
                        device.Size = SPMemoryDataType.Bank1.Size;
                        device.Speed = SPMemoryDataType.Bank1.Speed;
                        device.Info1 = "";
                        device.Info2 = "";
                        MacInfo.devices.Add(device);
                    }

                    MacInfo.Memory = SPMemoryDataType;
                }
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
