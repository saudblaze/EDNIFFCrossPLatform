using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.ViewModel
{
    public class vwSystemInfoDetail : vwSystemInfo
    {
        public string KeyboardBacklighttest { get; set; }
        public string SerialNumber { get; set; }
        public string PartNumber { get; set; }
        public string BoardTest { get; set; }
        public string StorageSmart { get; set; }
        public string StorageHealth { get; set; }
        public string Optical { get; set; }
        public string Webcam { get; set; }
        public string LAN { get; set; }
        public string Wifi { get; set; }
        public string Keyboard { get; set; }
        public string KeyboardLng { get; set; }
        public bool KeyboardBacklight { get; set; }
        public string KeyboardLayout { get; set; }
        //public string FingerPrint { get; set; }
        public string TrackPoint { get; set; }
        public string SpeakerTest { get; set; }
        public string BatteryTest { get; set; }
        public string BatteryHealth { get; set; }
        public string BatteryStatus { get; set; }
        public string BatteryBackup { get; set; }
        public string GRADE { get; set; }
        public string COA { get; set; }
        public string VideoCard { get; set; }
        public string VideoMemory { get; set; }
        public string Resolution { get; set; }
        public string TouchScreen { get; set; }
        public string ObservNotes { get; set; }
        public string MACADD { get; set; }
        public string Touchpad { get; set; }
        public string Bluetooth { get; set; }
        //public string ObservationComment { get; set; }
        //public ICollection<vwSystemDevice> Devices { get; set; }
        public long[] Observations { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string OrginalProductKey { get; set; }
        public string RamStatus { get; set; }
        public int? LotNumberOrGulfId { get; set; }
        public int NoOfPorts { get; set; }
        public string SDCardPort { get; set; }
        public string CellularPort { get; set; }
        public string BiometricSensorPort { get; set; }
        public string FaceRecognitionPort { get; set; }
        public string VGA_Port { get; set; }
        public string HDMI_Port { get; set; }
        public string Mini_Display_Port { get; set; }
        public string Display_Port { get; set; }
        public string Audio_Port { get; set; }
        public string SmartCard_Port { get; set; }

        //public ICollection<vwSystemPort> PortData { get; set; }
        public string UUID { get; set; }
        public string WIFI_Radio { get; set; }

        public string ProductId { get; set; }

        public string HardwareHash { get; set; }

        //public long? ModelId { get; set; }
        //public ICollection<SystemObservation> SystemObservations { get; set; }
        //public ICollection<DefectCode> DefectCodes { get; set; }
    }
}
