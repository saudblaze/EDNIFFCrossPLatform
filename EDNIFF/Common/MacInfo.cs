using EDNIFF.Models;
using EDNIFF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Common
{
    public static class MacInfo
    {
        public static SPHardwareDataType Hardware { get; set; }
        public static SPAudioDataType Audio { get; set; }
        public static SPBluetoothDataType Bluetooth { get; set; }
        public static SPDisplaysDataType Displays { get; set; }
        public static SPCameraDataType Camera { get; set; }
        public static SPMemoryDataType Memory { get; set; }
        public static SPSmartCardsDataType SmartCards { get; set; }
        public static SPThunderboltDataType Thunderbolt { get; set; }
        public static SPStorageDataType Storage { get; set; }
        public static SPWWANDataType WWAN { get; set; }
        public static SPUSBDataType USB { get; set; }
        public static SPPowerDataType Power { get; set; }
        public static SPNetworkDataType Network { get; set; }
        public static SPCardReaderDataType CardReader { get; set; }

        public static List<Device> devices { get; set; }

        public static bool IsTestCompleted { get; set; }

        public static string OSCOA { get; set; }

        public static string Resolution { get; set; }

        public static string ProcSpeed { get; set; }

        public static string StorageSize { get; set; }

        public static string StorageType { get; set; }

        static MacInfo()
        {
            devices = new List<Device>();
            IsTestCompleted = false;
        }


        public static MacinfoVM MapMacInfoVM( )
        {
            MacinfoVM objReturn = new MacinfoVM();
            if (MacInfo.Memory != null)
            {
                objReturn.Memory = MacInfo.Memory;
            }
            if (MacInfo.Hardware != null)
            {
                objReturn.Hardware = MacInfo.Hardware;
            }
            if (MacInfo.devices != null)
            {
                objReturn.devices = MacInfo.devices;
            }
            return objReturn;
        }

    }
}
