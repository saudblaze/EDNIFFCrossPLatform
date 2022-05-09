using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class DiskDriveService : BaseHardwareInfo
    {
        public bool GetDiskDrive(List<Device> devices)
        {
            bool found = false;
            var drives = base.GetDevices(ConstantData.DevicePaths.DiskDrive);
            foreach (var item in drives)
            {

                if (GetDevicePropertyValue(item, DeviceProps.DiskDrive.MediaType).ToLower().Contains("external"))
                    continue;
                if (GetDevicePropertyValue(item, DeviceProps.DiskDrive.InterfaceType).ToUpper() == "USB")
                    continue;
                if (GetDevicePropertyValue(item, DeviceProps.DiskDrive.Model).ToUpper() == "VIRTUAL")
                    continue;
                Device device = new Device();
                device.Category = ConstantData.Categories.Storage;
                device.DeviceName = ConstantData.DeviceNames.Storage;
                string[] model = GetDevicePropertyValue(item, DeviceProps.DiskDrive.Model).Split(' ');
                if (model.Length > 1)
                {
                    device.Manufacturer = model[0];
                    device.Model = model[1];
                }
                else
                {
                    device.Manufacturer = base.GetDevicePropertyValue(item, DeviceProps.DiskDrive.Manufacturer);
                    device.Model = model[0];
                }
                device.Serial = GetDevicePropertyValue(item, DeviceProps.DiskDrive.SerialNumber);
                device.Size = UtilityHelper.GetDataSizeHDD(GetDevicePropertyValue(item, DeviceProps.DiskDrive.Size));
                //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.DiskDrive.Speed));
                device.Info1 = GetDiskType(device.Serial);
                //device.Info1 = GetDevicePropertyValue(item, DeviceProps.DiskDrive.InterfaceType);
                device.Info2 = GetDevicePropertyValue(item, DeviceProps.DiskDrive.Description);
                device.Caption = GetDevicePropertyValue(item, DeviceProps.DiskDrive.Caption);
                //device.PNPDeviceId = GetDevicePropertyValue(item, "PNPDeviceId");
                //device.Info1 = GetDiskControllerType(GetDevicePropertyValue(item, "PNPDeviceID")) + " " + device.Info1;
                //device.Properties = item.Properties;
                device.validation = true;
                string NamespacePath = "\\\\.\\ROOT\\cimv2";
                string ClassName = "Win32_DiskDrive";
                byte[] failureDatas1 = new byte[0];
                ManagementClass oClass = new ManagementClass(NamespacePath + ":" + ClassName);
                foreach (ManagementObject oObject in oClass.GetInstances())
                {
                    var obj = oObject.Properties;
                    foreach (PropertyData property in oObject.Properties)
                    {
                        //failureDatas1 = property.Value;
                        if (property.Name.ToLower() == "status")
                        {
                            device.Status = property.Value.ToString();
                        }
                    }
                }
                devices.Add(device);
                found = true;
            }

            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Storage, ConstantData.DeviceNames.Storage));
            else //smart information
                PublicVariables.HDDSmartInfo = GetDrivesWithSMART();
            return found;
        }

        public bool GetCDROMDrive(List<Device> devices)
        {
            bool found = false;
            var drives = base.GetDevices(ConstantData.DevicePaths.CDROMDrive);
            foreach (var item in drives)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Other;
                device.DeviceName = ConstantData.DeviceNames.CDROMDrive;
                device.Manufacturer = base.GetDevicePropertyValue(item, DeviceProps.CDROMDrive.Manufacturer);
                device.Model = GetDevicePropertyValue(item, DeviceProps.CDROMDrive.Caption);
                device.Serial = GetDevicePropertyValue(item, DeviceProps.CDROMDrive.SerialNumber);
                //device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.CDROMDrive.Size));
                //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.DiskDrive.Speed));
                device.Info1 = GetDevicePropertyValue(item, DeviceProps.CDROMDrive.CapabilityDescriptions);
                device.Info2 = GetDevicePropertyValue(item, DeviceProps.CDROMDrive.Description);
                device.Caption = GetDevicePropertyValue(item, DeviceProps.CDROMDrive.Drive);
                //device.Properties = item.Properties;
                device.validation = true;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Other, ConstantData.DeviceNames.CDROMDrive));
            return found;
        }


        public void LoadSD(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.SDCardPort;
            string strScript = "Get-PnpDevice -Class 'MTD'";

            ////CHECK MODEL
            //Device deviceModel = new Device();
            //deviceModel = devices.Where(x => x.DeviceName == ConstantData.DeviceNames.System && (x.Model == "Latitude 5490" || x.Model == "ThinkPad T480" || x.Model == "ThinkPad T480s" || x.Model == "Latitude E5440" || x.Model == "ThinkPad T470s")).FirstOrDefault();
            //if (deviceModel != null)
            //{
            //    strScript = "Get-PnpDevice -Class 'DiskDrive'";
            //}

            // no sd card models
            Device deviceModelNoSDCard = new Device();
            deviceModelNoSDCard = devices.Where(x => x.DeviceName == ConstantData.DeviceNames.System && (x.Model == "EliteBook 850 G5" || x.Model == "EliteBook Folio 1040 G3")).FirstOrDefault();
            if (deviceModelNoSDCard != null)
            {
                device.deviceStatus = DeviceStatus.NotPresent;
                device.validation = false;
                devices.Add(device);
                return;
            }





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


            //if (deviceModel != null)
            //{
            //    if (stringBuilder.ToString().Contains("SD Card") || stringBuilder.ToString().Contains("Generic- SD/MMC USB Device") || stringBuilder.ToString().Contains("SD SCSI Disk Device") || stringBuilder.ToString().Contains("SDHC SCSI Disk Device"))
            //    {
            //        device.deviceStatus = DeviceStatus.NotTested;
            //        device.validation = true;
            //    }
            //    else
            //    {
            //        device.deviceStatus = DeviceStatus.NotPresent;
            //        device.validation = false;
            //    }
            //}
            //else
            //{
            //    if (stringBuilder.ToString() == "\r\n" || stringBuilder.ToString() == "")
            //    {
            //        device.deviceStatus = DeviceStatus.NotPresent;
            //        device.validation = false;
            //    }
            //    else
            //    {
            //        device.deviceStatus = DeviceStatus.NotTested;
            //        device.validation = true;
            //    }
            //}



            if (stringBuilder.ToString() == "\r\n" || stringBuilder.ToString() == "")
            {
                //device.deviceStatus = DeviceStatus.NotPresent;
                //device.validation = false;

                //now check for diskdrive
                strScript = "Get-PnpDevice -Class 'DiskDrive'";
                Runspace runspaceDisk = RunspaceFactory.CreateRunspace();
                runspaceDisk.Open();
                Pipeline pipelineDisk = runspaceDisk.CreatePipeline();
                pipelineDisk.Commands.AddScript(strScript);
                pipelineDisk.Commands.Add("Out-String");
                Collection<PSObject> resultsDisk = pipelineDisk.Invoke();
                runspaceDisk.Close();

                StringBuilder stringBuilderDisk = new StringBuilder();
                foreach (PSObject pSObject in resultsDisk)
                {
                    stringBuilderDisk.AppendLine(pSObject.ToString());
                }

                //MessageBox.Show(stringBuilderDisk, "Warning");


                if (stringBuilderDisk.ToString().Contains("SDHC Card") || stringBuilderDisk.ToString().Contains("SD Card") || stringBuilderDisk.ToString().Contains("Generic- SD/MMC USB Device") || stringBuilderDisk.ToString().Contains("SD SCSI Disk Device") || stringBuilderDisk.ToString().Contains("SDHC SCSI Disk Device"))
                {
                    device.deviceStatus = DeviceStatus.NotTested;
                    device.validation = true;
                }
                else
                {
                    device.deviceStatus = DeviceStatus.NotPresent;
                    device.validation = false;
                }


            }
            else
            {
                device.deviceStatus = DeviceStatus.NotTested;
                device.validation = true;
            }



            devices.Add(device);
        }

        public void LoadBiometricSensorPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.BiometricSensorPort;
            string strScript = "get-pnpdevice -class 'Biometric'";


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
            if (stringBuilder.ToString() == "\r\n" || stringBuilder.ToString() == "")
            {
                device.deviceStatus = DeviceStatus.NotPresent; //DeviceStatus.NotPresent;
                device.validation = false;
            }
            else
            {
                bool blnFingerprintExist = false;
                string strtemp = stringBuilder.ToString();
                string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string items in linesArr)
                {

                    if (items.ToString().Contains("OK") && (items.ToString().Contains("Control Vault w/ Fingerprint") || items.ToString().Contains("Synaptics") || items.ToString().Contains("Fingerprint")))
                    {
                        blnFingerprintExist = true;
                    }
                }
                if (blnFingerprintExist)
                {
                    device.deviceStatus = DeviceStatus.NotTested;
                    device.validation = true;
                }
                else
                {
                    device.deviceStatus = DeviceStatus.NotPresent; //DeviceStatus.NotPresent;
                    device.validation = false;
                }
            }

            devices.Add(device);
        }
        string GetDiskType(string serialno)
        {
            string rest = string.Empty;
            string bustype = string.Empty;
            var drives = base.GetDevicesByScope("MSFT_PhysicalDisk", @"\\.\root\microsoft\windows\storage");
            foreach (var item in drives)
            {
                if (GetDevicePropertyValue(item, DeviceProps.DiskDrive.SerialNumber).ToLower().Equals(serialno.ToLower()))
                {
                    switch (GetDevicePropertyValue(item, DeviceProps.DiskDrive.MediaType))
                    {
                        case "1":
                            rest = "Unspecified";
                            break;

                        case "3":
                            rest = "HDD";
                            break;

                        case "4":
                            rest = "SSD";
                            break;

                        case "5":
                            rest = "SCM";
                            break;

                        default:
                            rest = "Unspecified";
                            break;
                    }
                    break;
                }
            }
            foreach (var item in drives)
            {
                if (GetDevicePropertyValue(item, DeviceProps.DiskDrive.SerialNumber).ToLower().Equals(serialno.ToLower()))
                {
                    switch (GetDevicePropertyValue(item, DeviceProps.DiskDrive.BusType))
                    {
                        case "0":
                            bustype = "Unknown";
                            break;
                        case "1":
                            bustype = "SCSI";
                            break;
                        case "2":
                            bustype = "ATAPI";
                            break;

                        case "3":
                            bustype = "ATA";
                            break;

                        case "4":
                            bustype = "1394";
                            break;

                        case "5":
                            bustype = "SSA";
                            break;

                        case "6":
                            bustype = "Fibre Channel";
                            break;

                        case "7":
                            bustype = "USB";
                            break;

                        case "8":
                            bustype = "RAID";
                            break;

                        case "9":
                            bustype = "iSCSI";
                            break;

                        case "10":
                            bustype = "SAS";
                            break;

                        case "11":
                            bustype = "SATA";
                            break;

                        case "12":
                            bustype = "SD";
                            break;

                        case "13":
                            bustype = "MMC";
                            break;

                        case "14":
                            bustype = "Virtual";
                            break;

                        case "15":
                            bustype = "File Backed Virtual";
                            break;

                        case "16":
                            bustype = "Storage Spaces";
                            break;

                        case "17":
                            bustype = "NVMe";
                            break;

                        default:
                            bustype = "Unspecified";
                            break;
                    }
                    break;
                }
            }
            return bustype + ' ' + rest;
        }
        string GetDiskControllerType(string pnpId)
        {
            string rest = string.Empty;
            var ides = base.GetDevices("Win32_IDEControllerDevice");
            foreach (var item in ides)
            {
                if (GetDevicePropertyValue(item, "Dependent").Split('=')[1].Contains(pnpId.Replace("\\", "\\\\")))
                {
                    rest = GetDevicePropertyValue(item, "Antecedent").Split('=')[1].Replace("\\\\", "\\").Trim('"');
                    break;
                }
            }
            if (!string.IsNullOrEmpty(rest))
            {
                var idesCONT = base.GetDevices("Win32_IDEController");
                foreach (var item in idesCONT)
                {
                    if (GetDevicePropertyValue(item, "PNPDeviceID").Equals(rest))
                    {
                        if (GetDevicePropertyValue(item, "Caption").ToLower().Contains("sata"))
                            rest = "SATA";
                        break;
                    }
                }
            }
            return rest;
        }

        public List<HDDSmartInfo> GetDrivesWithSMART()
        {
            //var failureStatuses = convert(new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_FailurePredictStatus").Get());
            try
            {

                var dats = new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_FailurePredictThresholds");
                byte[] failureThresholddata = new byte[0];
                foreach (ManagementObject share in dats.Get())
                {
                    foreach (PropertyData property in share.Properties)
                    {
                        if (property.Name.ToLower() == "vendorspecific")
                        {
                            failureThresholddata = (byte[])property.Value;
                            break;
                        }
                    }
                }
                //var dats2 = new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_FailurePredictData");
                var dats2 = new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_ATAPISmartData");
                byte[] failureDatas = new byte[0];
                List<HDDSmartInfo> result = new List<HDDSmartInfo>();
                int index = 0;
                foreach (ManagementObject share in dats2.Get())
                {

                    foreach (PropertyData property in share.Properties)
                    {
                        if (property.Name.ToLower() == "vendorspecific")
                        {
                            failureDatas = (byte[])property.Value;
                            var SmartReadings = parseSmartData(failureDatas, failureThresholddata);
                            result.Add(new HDDSmartInfo { index = index, smartInfos = SmartReadings });
                            index++;
                            break;
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                ///remember to uncomment
                ///System.Windows.Forms.MessageBox.Show("Can't get HDD SMART info please run application as Administrator", "Info");
                return null;
            }
            //string manu = string.Empty;

            //var failureStatuses = convert(new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_FailurePredictStatus").Get());
            //var failureDatas = convert(new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_FailurePredictData").Get());
            //var failureThresholds = convert(new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_FailurePredictThresholds").Get());
            //var smartinfo = convert(new ManagementObjectSearcher(@"\root\wmi", "select * from MSStorageDriver_ATAPISmartData").Get());

            //var failureStatus = failureStatuses.FirstOrDefault(); //SingleOrDefault(f => ((string)f["InstanceName"]).ToUpper() == drive.DeviceId_PnP + "_0");
            //var failureData = failureDatas.FirstOrDefault();// .SingleOrDefault(f => ((string)f["InstanceName"]).ToUpper() == drive.DeviceId_PnP + "_0");
            //var failureThreshold = failureThresholds.FirstOrDefault();// .SingleOrDefault(f => ((string)f["InstanceName"]).ToUpper() == drive.DeviceId_PnP + "_0");

            //if (failureStatus == null || failureData == null || failureThreshold == null)
            //    throw new SmartReadException($"Could not find SMART data", drive);

            //var SmartPredictFailure = (bool)failureStatus["PredictFailure"];
            //var SmartReadings = parseSmartData((byte[])failureData["VendorSpecific"], (byte[])failureThreshold["VendorSpecific"]);
            // var strs = (byte[]) failureData["VendorSpecific"];
            //var strs = (byte[])smartinfo.FirstOrDefault()["VendorSpecific"];
            //var SmartReadings2 = parseSmartData((byte[])failureData["VendorSpecific"], strs);

            //SmartData(strs);

            //string manu = string.Empty;
            // var str = intString.Split('&');
            //foreach (var item in strs)
            //{
            //    int n = item;
            //    //int.TryParse(item, out n);
            //    if (n > 0)
            //        manu += Convert.ToChar(n);
            //}

            //manu = manu + "+";
            //var failureStatuses = base.GetDevicesWMI("MSStorageDriver_FailurePredictStatus");
            //var failureStatuses1 = base.GetDevicesByScope( "MSStorageDriver_FailurePredictStatus",@"\root\wmi");
            //var failureDatas = base.GetDevicesWMI("MSStorageDriver_FailurePredictData");
            //var failureThresholds = base.GetDevicesWMI( "MSStorageDriver_FailurePredictThresholds");

            //var SmartPredictFailure = GetDevicePropertyValue(failureStatuses[0], "PredictFailure");

            //var strs = UtilityHelper.GetDataFromIntString(GetDevicePropertyValue(failureDatas[0], "VendorSpecific"));
            //var strs2 = UtilityHelper.GetDataFromIntString(GetDevicePropertyValue(failureThresholds[0], "VendorSpecific"));



            //return drives;
        }
        private List<SmartInfo> parseSmartData(byte[] readings, byte[] thresholds)
        {
            var result = new List<SmartInfo>();
            int pos = 2; // first byte is clearly attribute count on some drives, but not on others :(
            while (pos <= readings.Length - 12)
            {
                byte id = readings[pos + 0];
                if (id == 0)
                    break;
                if (result.Any(r => r.InfoId == id))
                    break; // we're decoding junk now
                var reading = new SmartInfo();
                reading.InfoId = id;
                //reading.Flags = readings[pos + 2];
                reading.CurrentValue = readings[pos + 3];
                reading.WorstValue = readings[pos + 4];
                reading.AttributeName = GetAttributeName(id);
                //if(id==194) // for temperature 
                //{
                //    reading.Raw = BitConverter.ToInt32(readings, pos + 5);
                //}
                //else
                {
                    reading.Data = BitConverter.ToInt32(readings, pos + 5);
                }
                result.Add(reading);

                pos += 12;
            }

            pos = 2;
            while (pos <= thresholds.Length - 12)
            {
                byte id = thresholds[pos];
                byte threshold = thresholds[pos + 1];
                pos += 12;
                var reading = result.SingleOrDefault(r => r.InfoId == id);
                if (reading != null)
                    reading.ThresholdValue = threshold;
            }

            result.Sort((r1, r2) => r1.InfoId.CompareTo(r2.InfoId));
            return result;
        }
        //private static List<Dictionary<string, object>> convert(ManagementObjectCollection coll)
        //{
        //    return coll.OfType<ManagementObject>().Select(obj => obj.Properties.OfType<PropertyData>().ToDictionary(pd => pd.Name, pd => pd.Value)).ToList();
        //}

        // Dictionary<SmartAttributeType, SmartAttribute> attributes;
        //ushort structureVersion;
        //public void SmartData(byte[] arrVendorSpecific)
        //{
        //    attributes = new Dictionary<SmartAttributeType, SmartAttribute>();
        //    for (int offset = 2; offset < arrVendorSpecific.Length;)
        //    {
        //        var a = FromBytes<SmartAttribute>(arrVendorSpecific, ref offset, 12);
        //        // Attribute values 0x00, 0xfe, 0xff are invalid
        //        if (a.AttributeType != 0x00 && (byte)a.AttributeType != 0xfe && (byte)a.AttributeType != 0xff)
        //        {
        //            attributes[a.AttributeType] = a;
        //        }
        //    }
        //    structureVersion = (ushort)(arrVendorSpecific[0] * 256 + arrVendorSpecific[1]);
        //}
        //public ushort StructureVersion
        //{
        //    get
        //    {
        //        return this.structureVersion;
        //    }
        //}
        //public SmartAttribute this[SmartAttributeType v]
        //{
        //    get
        //    {
        //        return this.attributes[v];
        //    }
        //}

        //public IEnumerable<SmartAttribute> Attributes
        //{
        //    get
        //    {
        //        return this.attributes.Values;
        //    }
        //}
        //static T FromBytes<T>(byte[] bytearray, ref int offset, int count)
        //{
        //    IntPtr ptr = IntPtr.Zero;

        //    try
        //    {
        //        ptr = Marshal.AllocHGlobal(count);
        //        Marshal.Copy(bytearray, offset, ptr,(offset+ count > bytearray.Length ? bytearray.Length - offset : count));
        //        offset += count;
        //        return (T)Marshal.PtrToStructure(ptr, typeof(T));
        //    }
        //    finally
        //    {
        //        if (ptr != IntPtr.Zero)
        //        {
        //            Marshal.FreeHGlobal(ptr);
        //        }
        //    }
        //}
        private string GetAttributeName(int id)
        {
            if (AttributeNames.Any(x => x.Key == id))
            {
                var attr = AttributeNames.FirstOrDefault(x => x.Key == id);
                return attr.Value;
            }
            return string.Empty;
        }
        public IReadOnlyDictionary<byte, string> AttributeNames = new ReadOnlyDictionary<byte, string>(new Dictionary<byte, string>
        {
            { 0x01, "Read error rate" },
            { 0x02, "Throughput performance" },
            { 0x03, "Spin-up time" },
            { 0x04, "Start/stop count" },
            { 0x05, "Reallocated sector count" },
            { 0x07, "Seek error rate" },
            { 0x08, "Seek time performance" },
            { 0x09, "Power-on hours" },
            { 0x0A, "Spin retry count" },
            { 0x0B, "Recalibration retries" },
            { 0x0C, "Power cycle count" },
            { 0xB1, "Wear leveling count" },
            { 0xB3, "Used reserved block count" },
            { 0xB5, "Program fail count" },
            { 0xB6, "Erase fail count" },
            { 0xB7, "Runtime bad block" },
            { 0xB8, "End-to-end error" },
            { 0xBB, "Uncorrectable error count" },
            { 0xBC, "Command timeout" },
            { 0xBD, "High fly writes" },
            { 0xBE, "Airflow temperature" },
            { 0xBF, "G-sense error rate" },
            { 0xC0, "Power-off retract count" },
            { 0xC1, "Load/unload cycle count" },
            { 0xC2, "Temperature" },
            { 0xC3, "ECC error rate" },
            { 0xC4, "Reallocation event count" },
            { 0xC5, "Current pending sector count" },
            { 0xC6, "Uncorrectable sector count" },
            { 0xC7, "CRC error count" },
            { 0xC8, "Write error rate" },
            { 0xEB, "POR recovery count" },
            { 0xF0, "Head flying hours" },
            { 0xF1, "Total host writes" },
            { 0xF2, "Total host reads" },
        });

    }
}
