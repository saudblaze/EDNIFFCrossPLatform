using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class GraphicsService : BaseHardwareInfo
    {
        public void GetGraphics()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.Displays);
                if (!string.IsNullOrEmpty(strtemp))
                {
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPDisplaysDataType SPDisplaysDataType = new SPDisplaysDataType();

                    bool blnLCD1 = false;
                    bool blnLCD2 = false;

                    int iLCDCount = 0;
                    SPDisplaysDataType.Video = new Video();

                    foreach (string items in linesArr)
                    {
                        //Video
                        if (items.ToString().Contains("Chipset Model"))
                        {
                            SPDisplaysDataType.Video.ChipsetModel = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Type"))
                        {
                            SPDisplaysDataType.Video.Type = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Bus"))
                        {
                            SPDisplaysDataType.Video.Bus = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("VRAM"))
                        {
                            SPDisplaysDataType.Video.VRAM = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Vendor"))
                        {
                            SPDisplaysDataType.Video.Vendor = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Device ID"))
                        {
                            SPDisplaysDataType.Video.DeviceID = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Revision ID"))
                        {
                            SPDisplaysDataType.Video.RevisionID = GetPropertyValue(items.ToString());
                        }
                        if (items.ToString().Contains("Metal Family"))
                        {
                            SPDisplaysDataType.Video.MetalFamily = GetPropertyValue(items.ToString());
                        }


                        if (items.ToString().Contains("Color LCD"))
                        {
                            iLCDCount = iLCDCount + 1;
                            if (iLCDCount == 1)
                            {
                                SPDisplaysDataType.LCD1 = new LCD();
                            }
                            if (iLCDCount == 2)
                            {
                                SPDisplaysDataType.LCD2 = new LCD();
                            }

                        }



                        //LCD1
                        if (iLCDCount == 1 && items.ToString().Contains("Display Type"))
                        {
                            SPDisplaysDataType.LCD1.DisplayType = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("Resolution"))
                        {
                            SPDisplaysDataType.LCD1.Resolution = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("UI Looks like"))
                        {
                            SPDisplaysDataType.LCD1.UILooksLike = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("Framebuffer Depth"))
                        {
                            SPDisplaysDataType.LCD1.FramebufferDepth = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("Main Display"))
                        {
                            SPDisplaysDataType.LCD1.MainDisplay = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("Mirror"))
                        {
                            SPDisplaysDataType.LCD1.Mirror = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("Online"))
                        {
                            SPDisplaysDataType.LCD1.Online = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("Automatically Adjust Brightness"))
                        {
                            SPDisplaysDataType.LCD1.AutomaticallyAdjustBrightness = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 1 && items.ToString().Contains("Connection Type"))
                        {
                            SPDisplaysDataType.LCD1.ConnectionType = GetPropertyValue(items.ToString());
                        }


                        //LCD2
                        if (iLCDCount == 2 && items.ToString().Contains("Display Type"))
                        {
                            SPDisplaysDataType.LCD2.DisplayType = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("Resolution"))
                        {
                            SPDisplaysDataType.LCD2.Resolution = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("UI Looks like"))
                        {
                            SPDisplaysDataType.LCD2.UILooksLike = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("Framebuffer Depth"))
                        {
                            SPDisplaysDataType.LCD2.FramebufferDepth = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("Main Display"))
                        {
                            SPDisplaysDataType.LCD2.MainDisplay = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("Mirror"))
                        {
                            SPDisplaysDataType.LCD2.Mirror = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("Online"))
                        {
                            SPDisplaysDataType.LCD2.Online = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("Automatically Adjust Brightness"))
                        {
                            SPDisplaysDataType.LCD2.AutomaticallyAdjustBrightness = GetPropertyValue(items.ToString());
                        }
                        if (iLCDCount == 2 && items.ToString().Contains("Connection Type"))
                        {
                            SPDisplaysDataType.LCD2.ConnectionType = GetPropertyValue(items.ToString());
                        }
                    }


                    if (SPDisplaysDataType.Video != null)
                    {
                        Device device = new Device();
                        device.Category = ConstantData.Categories.Display;
                        device.DeviceName = ConstantData.DeviceNames.Video;
                        device.Manufacturer = SPDisplaysDataType.Video.Vendor;
                        device.Model = SPDisplaysDataType.Video.ChipsetModel;
                        device.Serial = SPDisplaysDataType.Video.DeviceID;
                        device.Size = SPDisplaysDataType.Video.VRAM;
                        device.Speed = "";
                        device.Info1 = "";
                        device.Info2 = "";
                        MacInfo.devices.Add(device);
                    }

                    if (SPDisplaysDataType.LCD1 != null)
                    {
                        Device device = new Device();
                        device.Category = ConstantData.Categories.Display;
                        device.DeviceName = ConstantData.DeviceNames.LCD;
                        device.Manufacturer = "";
                        device.Model = SPDisplaysDataType.LCD1.DisplayType;
                        device.Serial = "";
                        device.Size = SPDisplaysDataType.LCD1.UILooksLike;
                        device.Speed = "";
                        device.Info1 = "";
                        device.Info2 = "";
                        MacInfo.devices.Add(device);
                    }
                    if (SPDisplaysDataType.LCD2 != null)
                    {
                        Device device = new Device();
                        device.Category = ConstantData.Categories.Display;
                        device.DeviceName = ConstantData.DeviceNames.LCD;
                        device.Manufacturer = "";
                        device.Model = SPDisplaysDataType.LCD2.DisplayType;
                        device.Serial = "";
                        device.Size = SPDisplaysDataType.LCD2.UILooksLike;
                        device.Speed = "";
                        device.Info1 = "";
                        device.Info2 = "";
                        MacInfo.devices.Add(device);
                    }

                    
                }
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
