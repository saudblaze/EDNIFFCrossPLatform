using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Helpers
{
    public class ConstantData
    {
        public struct DevicePaths
        {
            public const string Processor = "Win32_Processor";
            public const string PhysicalMemory = "Win32_PhysicalMemory";
            public const string BaseBoard = "Win32_BaseBoard";
            public const string BIOS = "Win32_BIOS";
            public const string CDROMDrive = "Win32_CDROMDrive";
            public const string DisplayConfiguration = "Win32_DisplayConfiguration";
            public const string DisplayControllerConfiguration = "Win32_DisplayControllerConfiguration";
            public const string IDEController = "Win32_IDEController";
            public const string InfraredDevice = "Win32_InfraredDevice";
            public const string PortConnector = "Win32_PortConnector"; // to get list of all available ports like USB,VGS,Mini display
            public const string SoundDevice = "Win32_SoundDevice";
            public const string USBHUB = "Win32_USBHub";
            public const string USBController = "Win32_USBController";
            public const string USBControllerDevice = "Win32_USBControllerDevice";// to get no.usb ports and use devic id in pnpentity to get details
            public const string VideoController = "Win32_VideoController";
            public const string DiskDrive = "Win32_DiskDrive"; //to get HDD details need to exclude USB disk drive
            public const string DiskDriveSmartInfo = "MSStorageDriver_ATAPISmartData"; //to get HDD details need to exclude USB disk drive
            public const string DiskPartition = "Win32_DiskPartition"; // to get partition details
            public const string CacheMemory = "Win32_CacheMemory";
            public const string ComputerSystem = "Win32_ComputerSystem";
            public const string ComputerSystemProduct = "Win32_ComputerSystemProduct";
            public const string Keyboard = "Win32_Keyboard";
            public const string NetworkAdapter = "Win32_NetworkAdapter";
            public const string PointingDevice = "Win32_PointingDevice";
            public const string Batery = "Win32_Battery";
            public const string PortableBatery = "Win32_PortableBattery";
            public const string TimeZone = "Win32_TimeZone";


            public const string Hardware = "SPHardwareDataType";

            public const string Audio = "SPAudioDataType";

            public const string Memory = "SPMemoryDataType";

            public const string Bluetooth = "SPBluetoothDataType";

            public const string Camera = "SPCameraDataType";

            public const string CardReader = "SPCardReaderDataType";

            public const string Displays = "SPDisplaysDataType";

            public const string Battery = "SPPowerDataType";

            public const string Storage = "SPStorageDataType";

            public const string USB = "SPUSBDataType";

            public const string WIFI = "SPAirPortDataType";

            public const string Network = "SPNetworkDataType";

            public const string Ethernet = "SPEthernetDataType";

            public const string DiskBurning = "SPDiskBurningDataType";

            public const string OSCOA = "sw_vers";
        }


        //private List<DeviceMapping> _devicepaths;
        public enum Categories
        {
            MotherBoard,
            Processor,
            RAM,
            Storage,
            Battery,
            Display,
            //LCD,
            Audio,
            Microphone,
            Keyboard,
            Webcam,
            Touchpad,
            Network,
            Ports,
            Other
        }
        public enum DeviceNames
        {
            MotherBoard,//
            Processor,//
            RAM,//
            Storage,//
            Battery,
            Video,//
            LCD,//
            Audio,//
            Microphone,//
            Keyboard,//
            Webcam,//
            Touchpad,//
            Bluetooth,//
            LAN,//
            Wifi,//
            Infrared,
            USB_Port,//
            SmartCard_Port,
            HDD_Port,
            //Fingerprint,
            Trackpoint,
            CDROMDrive,//
            System,//
            TouchScreen,//
            Unknow,
            Ports,
            SDCardPort,
            CellularPort,
            BiometricSensorPort,
            FaceRecognitionPort,
            VGA_Port,
            HDMI_Port,
            Mini_Display_Port,
            Display_Port,
            Audio_Port
        }
        public enum ValidDeviceNames
        {

            Infrared,
            Others
        }

        public enum ReportProps
        {
            PartNumber,
            Manufacturer,
            Model,
            SerialNumber,
            BoardTest,
            Processor,
            ProcGen,
            ProcSpeed,
            RAM,
            StorageSize,
            StorageType,
            Keyboard,
            KeyboardLng,
            KeyboardBacklight,
            KeyboardBacklighttest,
            KeyboardLayout,
            Touchpad,
            Trackpoint,
            VideoCard,
            VideoMemory,
            Resolution,
            DisplaySize,
            TouchScreen,
            MADEIN,
            Optical,
            Webcam,
            LAN,
            MACADD,
            Wifi,
            //WifiMAC,
            Bluetooth,
            //Fingerprint,
            BatteryTest,
            BatteryHealth,
            OrginalProductKey,
            RamStatus,
            COA,
            UnitId,
            ObservNotes,
            SpeakerTest,
            BatteryStatus,
            Grade,
            StorageHealth,
            StorageSmart,
            BatteryBackup,
            SDCardPort,
            CellularPort,
            BiometricSensorPort,
            FaceRecognitionPort,
            VGA_Port,
            HDMI_Port,
            Mini_Display_Port,
            Display_Port,
            Audio_Port,
            SmartCard_Port,
            UUID,
            WIFI_Radio
        }
        public enum TestToPerform
        {
            None = 0,
            CMOS = 1,
            Speakers = 2,
            USBPorts = 3,
            LANPort = 4,
            OpticalDrive = 5,
            LCD = 6,
            Keyboard = 7,
            Touchpad = 8,
            Wifi = 9,
            Battery = 10,
            Webcam = 11,
            TouchScreen = 12,
            Microphone = 13,
            Blueooth = 14,
            SDCardPort = 15,
            BiometricSensorPort = 16,
            SmartCardPort = 17,
            Display = 18,
            Port = 19

        }
        
    }
}
