using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class VideoControllerService : BaseHardwareInfo
    {
        public bool GetVideoController(List<Device> devices)
        {
            bool found = false;
            var videocontroler = base.GetDevices(ConstantData.DevicePaths.VideoController + " where Status='Ok'");
            var video1 = base.GetDevices("CIM_VideoControllerResolution");
            var video2 = video1[video1.Count() - 1].Properties;
            string orgH = "";
            string orgW = "";
            foreach (var vid in video2)
            {
                if (vid.Name == "VerticalResolution")
                {
                    orgH = vid.Value;
                }
                if (vid.Name == "HorizontalResolution")
                {
                    orgW = vid.Value;
                }
            }
            if (devices == null)
                devices = new List<Device>();
            foreach (var item in videocontroler)
            {
                Device device = new Device();
                device.Category = ConstantData.Categories.Display;
                device.DeviceName = ConstantData.DeviceNames.Video;
                device.Manufacturer = GetDevicePropertyValue(item, DeviceProps.VideoController.AdapterCompatibility);
                device.Model = base.GetDevicePropertyValue(item, DeviceProps.VideoController.Caption);
                device.Description = GetDevicePropertyValue(item, DeviceProps.VideoController.Description);
                if (device.Manufacturer.Contains("Intel") == true)
                {
                    device.Size = "0 GB";
                }
                else
                {
                    device.Size = UtilityHelper.GetDataSize(GetDevicePropertyValue(item, DeviceProps.VideoController.AdapterRAM));
                }
                device.Speed = GetDevicePropertyValue(item, DeviceProps.VideoController.CurrentHorizontalResolution) + "x" + GetDevicePropertyValue(item, DeviceProps.VideoController.CurrentVerticalResolution);
                device.Info1 = GetDevicePropertyKeyValue(item, ConstantData.DeviceNames.Video, DeviceProps.VideoController.VideoArchitecture);
                device.Info2 = GetDevicePropertyKeyValue(item, ConstantData.DeviceNames.Video, DeviceProps.VideoController.VideoMemoryType);
                device.Caption = GetDevicePropertyValue(item, DeviceProps.VideoController.Caption);
                device.validation = true;
                devices.Add(device);
                found = true;
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Display, ConstantData.DeviceNames.Video));
            //int pixelsperinch = 96;
            //var display = base.GetDevices(ConstantData.DevicePaths.DisplayConfiguration);
            //if (display != null)
            //{
            //    var px = GetDevicePropertyValue(display.FirstOrDefault(), DeviceProps.DisplayConfiguration.LogPixels);
            //    int.TryParse(px, out pixelsperinch);
            //}
            found = false;
            int index = 0;
            var screens = GetDevicesWMI("WmiMonitorID");
            foreach (var screen in screens)
            {
                try
                {
                    Device device = new Device();
                    device.Category = ConstantData.Categories.Display;
                    device.DeviceName = ConstantData.DeviceNames.LCD;
                    device.Manufacturer = tempDbContext.DataBase.GetManufacurerName(UtilityHelper.GetDataFromIntString(GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.ManufacturerName)));
                    device.Serial = UtilityHelper.GetDataFromIntString(GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.SerialNumberID));
                    device.Model = UtilityHelper.GetDataFromIntString(GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.ProductCodeID));
                    device.Info2 = "Y:" + GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.YearOfManufacture) + " W:" + GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.WeekOfManufacture);
                    device.Caption = UtilityHelper.GetDataFromIntString(GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.UserFriendlyName));

                    ///remember to uncomment
                    //var item = System.Windows.Forms.Screen.AllScreens[index];
                    //double height = item.Bounds.Height;
                    //double width = item.Bounds.Width;

                    //if (index == 0)
                    //{
                    //    device.Info1 = $"{orgW} x {orgH}";// +"x"+ item.BitsPerPixel.ToString()+"="+ pixelsperinch.ToString();

                    //}
                    //else
                    //{

                    //    device.Info1 = $"{width} x {height}";// +"x"+ item.BitsPerPixel.ToString()+"="+ pixelsperinch.ToString();
                    //}

                    //height = height / item.BitsPerPixel;
                    //width = width / item.BitsPerPixel;
                    ////device.Size = (Math.Sqrt((height * height) + (width * width))/2.5).ToString(".0") + "\""; //2.5 is to convert cm to inches                  
                    ////device.Size = (Math.Ceiling(Convert.ToDecimal(Regex.Replace(GetDisplaySize(GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.InstanceName)), @"[^.0-9a-zA-Z]+", "")))).ToString() + "\"";
                    //device.Size = (Convert.ToDecimal(Regex.Replace(GetDisplaySize(GetDevicePropertyValue(screen, DeviceProps.WmiMonitorID.InstanceName)), @"[^.0-9a-zA-Z]+", ""))).ToString() + "\"";

                    device.validation = true;
                    //device.Speed = GetDevicePropertyValue(item, DeviceProps.VideoController.Name);
                    devices.Add(device);
                    index++;
                    found = true;

                }
                catch (Exception ex) { }
            }
            if (!found)
                devices.Add(GetEmptyDevice(ConstantData.Categories.Display, ConstantData.DeviceNames.LCD));
            return found;
        }
        string GetDisplaySize(string instancename)
        {
            string rest = string.Empty;
            var display = base.GetDevicesByScope(@"WMIMonitorBasicDisplayParams where InstanceName='" + instancename.Replace("\\", "\\\\") + "'", @"ROOT\WMI");
            if (display.Count == 0)
                return string.Empty;
            var disp = display.FirstOrDefault();

            string width = GetDevicePropertyValue(disp, "MaxHorizontalImageSize");
            string height = GetDevicePropertyValue(disp, "MaxVerticalImageSize");
            int h, w;
            int.TryParse(width, out w);
            int.TryParse(height, out h);
            return (Math.Sqrt((h * h) + (w * w)) / 2.54).ToString(".0") + "\"";
        }
    }
}
