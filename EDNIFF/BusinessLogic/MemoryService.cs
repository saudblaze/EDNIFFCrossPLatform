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
        public void GetHardware()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.Hardware);

                string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                SPMemoryDataType SPMemoryDataType = new SPMemoryDataType();

                foreach (string items in linesArr)
                {

                    bool blnBank0 = false;
                    bool blnBank1 = false;

                    if (items.ToString().Contains("ECC:"))
                    {
                        SPMemoryDataType.ECC = GetPropertyValue(items.ToString());
                    }

                    if (items.ToString().Contains("Upgradeable Memory"))
                    {
                        SPMemoryDataType.UpgradeableMemory = GetPropertyValue(items.ToString());
                    }

                    if (items.ToString().Contains("Bank 0"))
                    {
                        blnBank0 = true;
                        blnBank1 = false;
                    }

                    if (items.ToString().Contains("Bank 1"))
                    {
                        blnBank1 = true;
                        blnBank0 = false;
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

                MacInfo.Memory = SPMemoryDataType;

            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
