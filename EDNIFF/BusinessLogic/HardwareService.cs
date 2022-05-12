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
                string strtemp = GetInfoString(ConstantData.DevicePaths.Hardware);
                
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
                    }
                    if (items.ToString().Contains("Processor Speed"))
                    {
                        sPHardwareDataType.ProcessorSpeed = GetPropertyValue(items.ToString());
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

                MacInfo.Hardware = sPHardwareDataType;

            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }                
    }
}
