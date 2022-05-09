using EDNIFF.BusinessLogic;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BussinessLogic
{
    class ComputerSystemService : BaseHardwareInfo
    {
        public bool GetComputerSystemInfo(List<Device> devices)
        {
            bool found = false;
            var Vendor = "";
            var UUID = "";
            var Name = "";
            var Version = "";
            var system = base.GetDevices(ConstantData.DevicePaths.ComputerSystem);
            var systemproducts = base.GetDevices(ConstantData.DevicePaths.ComputerSystemProduct);
            foreach (var systemproduct in systemproducts)
            {
                Vendor = base.GetDevicePropertyValue(systemproduct, "Vendor");
                Name = base.GetDevicePropertyValue(systemproduct, "Name");
                Version = base.GetDevicePropertyValue(systemproduct, "Version");
                UUID = base.GetDevicePropertyValue(systemproduct, "UUID");
            }
            foreach (var systemproduct in systemproducts)
            {
                var Name1 = "";
                Vendor = base.GetDevicePropertyValue(systemproduct, "Vendor");
                if (Vendor == "HP" || Vendor == "Hewlett-Packard")
                {
                    Name1 = base.GetDevicePropertyValue(systemproduct, "Name");
                    Name1 = Name1.Replace("HP ", "");
                }
                else
                {
                    Name1 = base.GetDevicePropertyValue(systemproduct, "Name");
                }
                Name = Name1;
                Version = base.GetDevicePropertyValue(systemproduct, "Version");

            }
            foreach (var item in system)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Other;
                device.DeviceName = ConstantData.DeviceNames.System;
                device.Manufacturer = Vendor;
                device.Model = Name;
                device.Serial = GetDevicePropertyValue(item, DeviceProps.ComputerSystem.SystemSKUNumber);

                if (device.Manufacturer.ToLower() == "lenovo")
                {
                    //string tmp = device.Serial;
                    device.Serial = device.Model;
                    device.Model = Version;
                }
                //device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.ComputerSystem.Capacity));
                //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.ComputerSystem.Speed));
                //device.Info1 = GetDevicePropertyKeyValue(item, ConstantData.DeviceNames.RAM, DeviceProps.ComputerSystem.SMBIOSMemoryType);
                //device.Info2 = GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Description);
                device.Caption = OSProductKeyInfo();// GetDevicePropertyValue(item, DeviceProps.Processor.Caption);
                //device.Properties = item.Properties;
                device.validation = true;
                device.Info1 = UUID;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Other, ConstantData.DeviceNames.System));
            return found;
        }
        public bool GetBiosInfo(List<Device> devices)
        {
            bool found = false;
            var system = base.GetDevices(ConstantData.DevicePaths.BIOS);
            if (devices == null)
                devices = new List<Device>();
            foreach (var item in system)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.MotherBoard;
                device.DeviceName = ConstantData.DeviceNames.MotherBoard;
                device.Manufacturer = base.GetDevicePropertyValue(item, DeviceProps.BIOS.Manufacturer);
                device.Model = GetDevicePropertyValue(item, DeviceProps.BIOS.Version);
                device.Serial = GetDevicePropertyValue(item, DeviceProps.BIOS.SerialNumber);
                //device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.ComputerSystem.Capacity));
                //device.Speed = UtilityHelper.GetProcessingSpeed(GetDevicePropertyValue(item, DeviceProps.ComputerSystem.Speed));
                //device.Info1 = GetDevicePropertyKeyValue(item, ConstantData.DeviceNames.RAM, DeviceProps.ComputerSystem.SMBIOSMemoryType);
                //device.Info2 = GetDevicePropertyValue(item, DeviceProps.PhysicalMemory.Description);
                //device.Caption = GetDevicePropertyValue(item, DeviceProps.Processor.Caption);
                //device.Properties = item.Properties;
                SetBoardRamStatus(device);
                device.deviceStatus = DeviceStatus.NotTested;//self tested for CMOS
                device.validation = true;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.MotherBoard, ConstantData.DeviceNames.MotherBoard));
            return found;
        }
        public bool GetTouchScreen(List<Device> devices)
        {
            bool found = IsTouchEnabled();
            // System.Windows.Forms.SystemInformation
            //temporary shown
            if (found)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Display;
                device.DeviceName = ConstantData.DeviceNames.TouchScreen;
                device.validation = true;
                //device.Manufacturer = System.Windows.Forms.SystemInformation..Width.ToString() + "X" + System.Windows.Forms.SystemInformation.MaxWindowTrackSize.Height.ToString();
                //device.Model = System.Windows.Forms.SystemInformation.MaxWindowTrackSize.Width.ToString() + "X" + System.Windows.Forms.SystemInformation.MaxWindowTrackSize.Height.ToString();
                //device.Size = System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Width.ToString() + "X" + System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Height.ToString();
                //device.Speed = System.Windows.Forms.SystemInformation.WorkingArea.Width.ToString() + "X" + System.Windows.Forms.SystemInformation.WorkingArea.Height.ToString();
                devices.Add(device);
                // found = true;
            }
            else
                devices.Add(GetEmptyDevice(ConstantData.Categories.Display, ConstantData.DeviceNames.TouchScreen, DeviceStatus.NotPresent));
            return found;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

        public bool IsTouchEnabled()
        {
            const int MAXTOUCHES_INDEX = 95;
            int maxTouches = GetSystemMetrics(MAXTOUCHES_INDEX);

            return maxTouches > 0;
        }

        public bool GetBatteryInfo(List<Device> devices)
        {
            bool found = false;
            ///remember to uncomment
            //if (System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus == System.Windows.Forms.BatteryChargeStatus.NoSystemBattery)
            //    devices.Add(GetEmptyDevice(ConstantData.Categories.Battery, ConstantData.DeviceNames.Battery));
            //else
            //{
            //    var batterys = base.GetDevicesWMI("BatteryStaticData");
            //    var batteryin = base.GetDevices("win32_battery");
            //    List<Device> otherbetteryinfo = GetBatteryRemainingCharge();
            //    int i = 1;
            //    int j = 0;
            //    foreach (var item in batterys)
            //    {
            //        Device device = new Device();
            //        device.Category = ConstantData.Categories.Battery;
            //        device.DeviceName = ConstantData.DeviceNames.Battery;
            //        device.Caption = DateTime.Now.ToString(); //will be used for battery calculation
            //        device.Manufacturer = GetDevicePropertyValue(item, "ManufactureName");
            //        device.DeviceId = GetDevicePropertyValue(item, "UniqueID");
            //        string[] temp = GetDevicePropertyValue(item, "SerialNumber").Split(' ');
            //        if (temp.Length > 1)
            //        {
            //            device.Serial = temp[0];
            //            device.Info2 = temp[1];
            //        }
            //        else if (temp.Length == 1)
            //        {
            //            device.Serial = temp[0];
            //        }
            //        device.Caption = "Battery " + i.ToString();
            //        i++;
            //        //if (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent >= 0)
            //        //    device.Size = (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString() + "%";

            //        var bat = otherbetteryinfo.FirstOrDefault(x => x.DeviceId == device.DeviceId);
            //        if (bat != null)
            //        {
            //            device.Size = bat.Size;
            //        }
            //        double.TryParse(GetDevicePropertyValue(item, "DesignedCapacity"), out double designedcapacity);
            //        var fullcap = base.GetDevicesWMI("BatteryFullChargedCapacity").ToList()[j];
            //        j++;
            //        if (fullcap != null)
            //        {
            //            double.TryParse(GetDevicePropertyValue(fullcap, "FullChargedCapacity"), out double fullcapacity);
            //            if ((int)(fullcapacity) == 0)
            //            {
            //                device.Info1 = "0%";
            //            }
            //            else if ((int)((fullcapacity / designedcapacity) * 100) > 100)
            //            {
            //                device.Info1 = "100%";
            //            }
            //            else
            //            {
            //                device.Info1 = ((int)((fullcapacity / designedcapacity) * 100)).ToString() + "%";
            //            }
            //        }
            //        //device.Caption = DateTime.Now.ToString(); //will be used for battery calculation
            //        //device.Model = GetDevicePropertyValue(item, "Manufacturer");
            //        //device.Serial = GetDevicePropertyValue(item, "Name");
            //        //if (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent >= 0)
            //        //    device.Info1 = (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString();
            //        //device.Info2 = GetDevicePropertyValue(item, "DesignCapacity");
            //        device.validation = true;

            //        devices.Add(device);
            //        found = true;
            //    }
            //}
            return found;
        }

        public List<Device> FindGetBatteryInfo(List<Device> mydevices)
        {
            ///remember to uncomment
            //if (System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus == System.Windows.Forms.BatteryChargeStatus.NoSystemBattery)
            //    mydevices.Add(GetEmptyDevice(ConstantData.Categories.Battery, ConstantData.DeviceNames.Battery));
            //else
            //{
            //    var batterys = base.GetDevicesWMI("BatteryStaticData");
            //    var batteryin = base.GetDevices("win32_battery");
            //    List<Device> otherbetteryinfo = GetBatteryRemainingCharge();
            //    int i = 1;
            //    foreach (var item in batterys)
            //    {
            //        Device device = new Device();
            //        device.Category = ConstantData.Categories.Battery;
            //        device.DeviceName = ConstantData.DeviceNames.Battery;
            //        device.Caption = DateTime.Now.ToString(); //will be used for battery calculation
            //        device.Manufacturer = GetDevicePropertyValue(item, "ManufactureName");
            //        device.DeviceId = GetDevicePropertyValue(item, "UniqueID");
            //        string[] temp = GetDevicePropertyValue(item, "SerialNumber").Split(' ');
            //        if (temp.Length > 1)
            //        {
            //            device.Serial = temp[0];
            //            device.Info2 = temp[1];
            //        }
            //        else if (temp.Length == 1)
            //        {
            //            device.Serial = temp[0];
            //        }
            //        device.Caption = "Battery " + i.ToString();
            //        i++;
            //        //if (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent >= 0)
            //        //    device.Size = (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString() + "%";

            //        var bat = otherbetteryinfo.FirstOrDefault(x => x.DeviceId == device.DeviceId);
            //        if (bat != null)
            //        {
            //            device.Size = bat.Size;
            //        }
            //        double.TryParse(GetDevicePropertyValue(item, "DesignedCapacity"), out double designedcapacity);
            //        var fullcap = base.GetDevicesWMI("BatteryFullChargedCapacity").FirstOrDefault();

            //        if (fullcap != null)
            //        {
            //            double.TryParse(GetDevicePropertyValue(fullcap, "FullChargedCapacity"), out double fullcapacity);
            //            if ((int)(fullcapacity) == 0)
            //            {
            //                device.Info1 = "0%";
            //            }
            //            else if ((int)((fullcapacity / designedcapacity) * 100) > 100)
            //            {
            //                device.Info1 = "100%";
            //            }
            //            else
            //            {
            //                device.Info1 = ((int)((fullcapacity / designedcapacity) * 100)).ToString() + "%";
            //            }
            //        }
            //        //device.Caption = DateTime.Now.ToString(); //will be used for battery calculation
            //        //device.Model = GetDevicePropertyValue(item, "Manufacturer");
            //        //device.Serial = GetDevicePropertyValue(item, "Name");
            //        //if (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent >= 0)
            //        //    device.Info1 = (System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString();
            //        //device.Info2 = GetDevicePropertyValue(item, "DesignCapacity");
            //        device.validation = true;

            //        mydevices.Add(device);
            //    }
            //}
            return mydevices;
        }

        public string OSProductKeyInfo()
        {
            //var osinfo = base.GetDevicesByQuery("select OA3xOriginalProductKey,OA3xOriginalProductKeyDescription from SoftwareLicensingService");
            var osinfo = base.GetDevicesByQuery("select OA3xOriginalProductKey from SoftwareLicensingService");
            if (osinfo != null && osinfo.Count() > 0)
                return GetDevicePropertyValue(osinfo.FirstOrDefault(), DeviceProps.Processor.OA3xOriginalProductKey);
            else
                return string.Empty;
        }

        private void SetBoardRamStatus(Device device)
        {
            var system = base.GetDevices(ConstantData.DevicePaths.BaseBoard).FirstOrDefault();
            if (system != null)
            {
                bool.TryParse(GetDevicePropertyValue(system, DeviceProps.PhysicalMemory.Removable), out bool removable);
                device.boolInfo1 = removable;
                bool.TryParse(GetDevicePropertyValue(system, DeviceProps.PhysicalMemory.Replaceable), out bool replaceable);
                device.boolInfo2 = replaceable;
            }
        }


        public List<Device> GetBatteryRemainingCharge()
        {
            List<Device> otherbetteryinfo = new List<Device>();
            ///remember to uncomment
            //if (!(System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus == System.Windows.Forms.BatteryChargeStatus.NoSystemBattery))
            //{

            //    var batteryin = base.GetDevices("win32_battery");
            //    foreach (var item in batteryin)
            //    {
            //        var x = GetDevicePropertyValue(item, "EstimatedChargeRemaining");
            //        if (x == "")
            //        {
            //            x = "0";
            //        }
            //        else if (Int32.Parse(x) > 100)
            //        {
            //            x = "100";
            //        }
            //        otherbetteryinfo.Add(new Device
            //        {
            //            DeviceId = GetDevicePropertyValue(item, "DeviceId"),
            //            Size = x + "%"
            //        });
            //    }

            //}
            return otherbetteryinfo;
        }
    }
}
