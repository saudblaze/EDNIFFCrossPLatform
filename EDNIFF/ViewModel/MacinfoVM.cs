using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.ViewModel
{
    public class MacinfoVM
    {
        public SPHardwareDataType Hardware { get; set; }
        public SPAudioDataType Audio { get; set; }
        public SPBluetoothDataType Bluetooth { get; set; }
        public SPDisplaysDataType Displays { get; set; }
        public SPCameraDataType Camera { get; set; }
        public SPMemoryDataType Memory { get; set; }
        public SPSmartCardsDataType SmartCards { get; set; }
        public SPThunderboltDataType Thunderbolt { get; set; }
        public SPStorageDataType Storage { get; set; }
        public SPWWANDataType WWAN { get; set; }
        public SPUSBDataType USB { get; set; }
        public SPPowerDataType Power { get; set; }
        public SPNetworkDataType Network { get; set; }
        public SPCardReaderDataType CardReader { get; set; }


        public List<Device> devices { get; set; }
    }
}
