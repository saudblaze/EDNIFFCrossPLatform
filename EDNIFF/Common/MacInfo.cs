﻿using EDNIFF.Models;
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

    }
}
