using AForge.Video.DirectShow;
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
    public class OtherDeviceService
    {
        #region --other devices--
        public void LoadCamera(List<Device> devices)
        {
            FilterInfoCollection filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //WebCameraControl cameraControl = new WebCameraControl();
            Device device = new Device();
            device.Category = ConstantData.Categories.Webcam;
            device.DeviceName = ConstantData.DeviceNames.Webcam;
            //device.Properties = item.Properties;
            if (filterInfoCollection.Count == 0)
            {
                device.deviceStatus = DeviceStatus.NotPresent;
                device.validation = false;
            }
            else
            {
                device.deviceStatus = DeviceStatus.NotTested;
                device.validation = true;
            }
            devices.Add(device);
            filterInfoCollection = null;
        }
        public void LoadMicrophone(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Microphone;
            device.DeviceName = ConstantData.DeviceNames.Microphone;
            //device.Properties = item.Properties;
            if (NAudio.Wave.WaveIn.DeviceCount > 0)
            {
                device.deviceStatus = DeviceStatus.NotTested;
                device.validation = true;
            }
            else
            {
                device.deviceStatus = DeviceStatus.NotPresent;
                device.validation = false;
            }
            devices.Add(device);
        }
        public void LoadSDCard(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.SDCardPort;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }
        public void LoadCellularPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.CellularPort;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }
        public void LoadBiometricSensorPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.BiometricSensorPort;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }
        public void LoadFaceRecognitionPort(List<Device> devices)
        {
            var cameraNames = new List<string>();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Camera') "))
            {
                foreach (var deviceIRs in searcher.Get())
                {
                    cameraNames.Add(deviceIRs["Caption"].ToString());
                }
            }
            Device deviceIR = new Device();
            deviceIR.Category = ConstantData.Categories.Ports;
            deviceIR.DeviceName = ConstantData.DeviceNames.FaceRecognitionPort;
            if (cameraNames != null && cameraNames.Count > 0)
            {
                bool isIRCameraExists = false;
                foreach (string CameraName in cameraNames)
                {
                    if (CameraName.Contains("IR Camera"))
                    {
                        isIRCameraExists = true;
                        break;
                    }
                }
                if (isIRCameraExists)
                {

                    deviceIR.deviceStatus = DeviceStatus.NotTested;
                    deviceIR.validation = true;
                }
                else
                {
                    deviceIR.deviceStatus = DeviceStatus.NotPresent;
                    deviceIR.validation = false;
                }
            }
            else
            {
                //first check with if camera is available with image class 

                string strScript = "Get-PnpDevice -Class 'image'";
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
                    deviceIR.deviceStatus = DeviceStatus.NotPresent; //DeviceStatus.NotPresent;
                    deviceIR.validation = false;
                }
                else
                {
                    bool blnCameraExist = false;
                    int CameraCount = 0;
                    string strtemp = stringBuilder.ToString();
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (string items in linesArr)
                    {
                        if (items.ToString().Contains("OK") && (items.ToString().Contains("Integrated Webcam")))
                        {
                            blnCameraExist = true;
                        }
                        if (blnCameraExist)
                        {
                            CameraCount++;
                            blnCameraExist = false;
                        }
                    }
                    if (CameraCount == 2)
                    {
                        deviceIR.deviceStatus = DeviceStatus.NotTested;
                        deviceIR.validation = false;
                    }
                    else
                    {
                        deviceIR.deviceStatus = DeviceStatus.NotPresent;
                        deviceIR.validation = false;
                    }
                }


                //deviceIR.deviceStatus = DeviceStatus.NotPresent;
                //deviceIR.validation = false;
            }
            devices.Add(deviceIR);
        }
        public void LoadVGAPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.VGA_Port;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }
        public void LoadHDMIPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.HDMI_Port;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }
        public void LoadMiniDisplayPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.Mini_Display_Port;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }
        public void LoadDisplayPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.Display_Port;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }

        public void LoadAudioPort(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.Audio_Port;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }

        public void AddUSBDevice(List<Device> devices)
        {
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.USB_Port;
            device.deviceStatus = DeviceStatus.NotTested;
            device.validation = true;
            devices.Add(device);
        }
        //public void GetSmartCard(List<Device> devices)
        //{
        //    //var card= ob.AutoDetectReader();
        //    Device device = new Device();
        //    device.Category = ConstantData.Categories.Ports;
        //    device.DeviceName = ConstantData.DeviceNames.SmartCard_Port;
        //    try
        //    {
        //        string readername = string.Empty;
        //        var contextFactory = ContextFactory.Instance;
        //        using (var context = contextFactory.Establish(SCardScope.System))
        //        {
        //            var readerNames = context.GetReaders();
        //            foreach (var readerName in readerNames)
        //            {
        //                readername = readerName.ToString();
        //                if (!string.IsNullOrEmpty(readername))
        //                    break;
        //            }
        //        }
        //        if (!string.IsNullOrEmpty(readername))
        //            device.deviceStatus = DeviceStatus.NotTested;
        //        else
        //        {

        //            //TOC.SmartCardReader.HDMICardContext ob = new TOC.SmartCardReader.HDMICardContext();
        //            //device.deviceStatus = DeviceStatus.NotTested;
        //            ////ob.Initilize();
        //            //var obss = ob.GetConnectedReaders();
        //            device.deviceStatus = DeviceStatus.NotPresent;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message, "Info");
        //        device.deviceStatus = DeviceStatus.NotPresent;
        //    }
        //    device.validation = true;
        //    devices.Add(device);
        //}
        public void GetSmartCard(List<Device> devices)
        {
            //var card= ob.AutoDetectReader();
            Device device = new Device();
            device.Category = ConstantData.Categories.Ports;
            device.DeviceName = ConstantData.DeviceNames.SmartCard_Port;
            device.deviceStatus = DeviceStatus.NotTested;
            //device.validation = true;



            //string strScript = "Get-PnpDevice -Class 'SmartCardReader'";

            //try
            //{
            //    Runspace runspace = RunspaceFactory.CreateRunspace();
            //    runspace.Open();
            //    Pipeline pipeline = runspace.CreatePipeline();
            //    pipeline.Commands.AddScript(strScript);
            //    pipeline.Commands.Add("Out-String");
            //    Collection<PSObject> results = pipeline.Invoke();
            //    runspace.Close();

            //    StringBuilder stringBuilder = new StringBuilder();
            //    foreach (PSObject pSObject in results)
            //    {
            //        stringBuilder.AppendLine(pSObject.ToString());
            //    }

            //    if (stringBuilder.ToString() != "\r\n" && stringBuilder.ToString() != "" && stringBuilder.ToString() != Environment.NewLine)
            //    {
            //        String strtemp = stringBuilder.ToString();
            //        string strtempSize = string.Empty;
            //        bool blnIsSmartcardreader = false;
            //        string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            //        foreach (string items in linesArr)
            //        {
            //            if (items.ToString().Contains("OK") && (items.ToString().Contains("SmartCardReader") || items.ToString().Contains("Microsoft Usbccid Smartcard Reader (WUDF)")))
            //            {
            //                blnIsSmartcardreader = true;
            //                break;
            //            }
            //        }

            //        if (blnIsSmartcardreader == true)
            //        {
            //            device.deviceStatus = DeviceStatus.NotTested;
            //            device.validation = true;
            //        }
            //        else
            //        {
            //            device.deviceStatus = DeviceStatus.NotPresent;
            //            device.validation = false;
            //        }
            //    }
            //    else
            //    {
            //        device.deviceStatus = DeviceStatus.NotPresent;
            //        device.validation = false;
            //    }


            //}
            //catch (Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message, "Info");
            //    device.deviceStatus = DeviceStatus.NotPresent;
            //}
            device.validation = true;
            devices.Add(device);
        }
        #endregion
    }
}
