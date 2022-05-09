using EDNIFF.BusinessLogic;
using EDNIFF.BussinessLogic;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Common
{
    public class SystemInfo
    {
        public List<Device> devices;
        //public static Dictionary<long, string> observations { get; set; }
        //public static long[] observations { get; set; }


        public SystemInfo()
        {
            //observations = new Dictionary<int, string>();
        }
        #region --private methods--
        public void LoadDevices()
        {
            devices = new List<Device>();
            //LoadProcessor();
            //LoadMemory();
            //LoadVideo();
            //LoadSound();
            //LoadDiskDrive();
            //LoadSystemDetails();
            //LoadOtherDevices();
        }
        private void LoadSystemDetails()
        {
            ComputerSystemService diskService = new ComputerSystemService();
            diskService.GetComputerSystemInfo(devices);
            diskService.GetBiosInfo(devices);
            diskService.GetTouchScreen(devices);
            diskService.GetBatteryInfo(devices);
        }
        private void LoadDiskDrive()
        {
            DiskDriveService diskService = new DiskDriveService();
            diskService.GetDiskDrive(devices);
            diskService.GetCDROMDrive(devices);
        }
        private void LoadSound()
        {
            AudioService audioService = new AudioService();
            audioService.GetSoundDevice(devices);
            //audioService.GetMicrophoneDevice(devices);// temporaray added
        }
        private void LoadProcessor()
        {
            ProcessorService processor = new ProcessorService();
            processor.GetProcessorInfo(devices);
        }
        private void LoadMemory()
        {
            PhysicalMemoryService memoryService = new PhysicalMemoryService();
            memoryService.GetPhysicalMemory(devices);
        }
        private void LoadVideo()
        {
            VideoControllerService video = new VideoControllerService();
            video.GetVideoController(devices);
        }

        private void LoadOtherDevices()
        {
            DiskDriveService diskService = new DiskDriveService();
            KeyboardService keyboard = new KeyboardService();
            keyboard.GetKeyboardDevice(devices);
            TouchpadService touchpad = new TouchpadService();
            touchpad.GetPointingDevice(devices);
            NetworkService network = new NetworkService();
            network.GetNetworkDevices(devices);
            OtherDeviceService other = new OtherDeviceService();
            other.LoadCamera(devices);
            other.LoadMicrophone(devices);
            other.AddUSBDevice(devices);
            other.GetSmartCard(devices);
            other.LoadSDCard(devices);
            //diskService.LoadSD(devices);
            //diskService.LoadBiometricSensorPort(devices);
            other.LoadCellularPort(devices);
            other.LoadBiometricSensorPort(devices);
            other.LoadFaceRecognitionPort(devices);
            other.LoadVGAPort(devices);
            other.LoadHDMIPort(devices);
            other.LoadMiniDisplayPort(devices);
            other.LoadDisplayPort(devices);
            other.LoadAudioPort(devices);
        }
        //private void GetSystemInfo()
        //{
        //    SystemReportService system = new SystemReportService();
        //       List<TestResult>   result = system.GetSystemInfo(devices);
        //}

        #endregion

    }
}
