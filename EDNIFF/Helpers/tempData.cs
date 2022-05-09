using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;

namespace EDNIFF.Helpers
{
    public class tempData
    {

        private List<KeyValue> _devicedataKeyValue;

        private List<KeyValueText> _manufacturers;
        public tempData()
        {
            LoadManufacturers();
            _devicedataKeyValue = new List<KeyValue>();
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Processor, PropertyName = DeviceProps.Processor.ProcessorType.ToString(), Key = 1, Value = "Other" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Processor, PropertyName = DeviceProps.Processor.ProcessorType.ToString(), Key = 2, Value = "Unknown" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Processor, PropertyName = DeviceProps.Processor.ProcessorType.ToString(), Key = 3, Value = "Central Processor" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Processor, PropertyName = DeviceProps.Processor.ProcessorType.ToString(), Key = 4, Value = "Math Processor" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Processor, PropertyName = DeviceProps.Processor.ProcessorType.ToString(), Key = 5, Value = "DSP Processor" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Processor, PropertyName = DeviceProps.Processor.ProcessorType.ToString(), Key = 6, Value = "Video Processor" });


            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 0, Value = "Unknown" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 1, Value = "Other" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 2, Value = "DRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 3, Value = "Synchronous DRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 4, Value = "Cache DRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 5, Value = "EDO" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 6, Value = "EDRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 7, Value = "VRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 8, Value = "SRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 9, Value = "RAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 10, Value = "ROM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 11, Value = "Flash" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 12, Value = "EEPROM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 13, Value = "FEPROM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 14, Value = "EPROM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 15, Value = "CDRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 16, Value = "3DRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 17, Value = "SDRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 18, Value = "SGRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 19, Value = "RDRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 20, Value = "DDR" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 21, Value = "DDR2" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 22, Value = "DDR2 FB-DIMM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 23, Value = "Undefined 23" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 24, Value = "DDR3" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 25, Value = "FBD2" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.RAM, PropertyName = DeviceProps.PhysicalMemory.SMBIOSMemoryType.ToString(), Key = 26, Value = "DDR4" });


            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 1, Value = "Other" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 2, Value = "Unknown" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 3, Value = "CGA" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 4, Value = "EGA" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 5, Value = "VGA" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 6, Value = "SVGA" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 7, Value = "MDA" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 8, Value = "HGC" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 9, Value = "MCGA" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 10, Value = "8514A" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 11, Value = "XGA" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 12, Value = "Linear Frame Buffer" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoArchitecture.ToString(), Key = 160, Value = "PC - 98" });



            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 1, Value = "Other" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 2, Value = "Unknown" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 3, Value = "VRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 4, Value = "DRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 5, Value = "SRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 6, Value = "WRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 7, Value = "EDO RAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 8, Value = "Burst Synchronous DRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 9, Value = "Pipelined Burst SRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 10, Value = "CDRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 11, Value = "3DRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 12, Value = "SDRAM" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Video, PropertyName = DeviceProps.VideoController.VideoMemoryType.ToString(), Key = 13, Value = "SGRAM" });



            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 0, Value = "Disconnected" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 1, Value = "Connecting" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 2, Value = "Connected" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 3, Value = "Disconnecting" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 4, Value = "Hardware Not Present" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 5, Value = "Hardware Disabled" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 6, Value = "Hardware Malfunction" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 7, Value = "Media Disconnected" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 8, Value = "Authenticating" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 9, Value = "Authentication Succeeded" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 10, Value = "Authentication Failed" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 11, Value = "Invalid Address" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 12, Value = "Credentials Required" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.LAN, PropertyName = DeviceProps.NetworkAdapter.NetConnectionStatus.ToString(), Key = 13, Value = "Other 13–65535" });


            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 0, Value = "None" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 1, Value = "Parallel Port XT/AT Compatible" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 2, Value = "Parallel Port PS/2 " });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 3, Value = "Parallel Port ECP" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 4, Value = "Parallel Port EPP" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 5, Value = "Parallel Port ECP/EPP" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 6, Value = "Serial Port XT/AT Compatible" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 7, Value = "Serial Port 16450 Compatible" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 8, Value = "Serial Port 16550 Compatible" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 9, Value = "Serial Port 16550A Compatible" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 10, Value = "SCSI Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 11, Value = "MIDI Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 12, Value = "Joy Stick Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 13, Value = "Keyboard Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 14, Value = "Mouse Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 15, Value = "SSA SCSI" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 16, Value = "USB" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 17, Value = "FireWire (IEEE P1394)" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 18, Value = "PCMCIA Type II" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 19, Value = "PCMCIA Type II" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 20, Value = "PCMCIA Type III" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 21, Value = "Cardbus" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 22, Value = "Access Bus Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 23, Value = "SCSI II" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 24, Value = "SCSI Wide" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 25, Value = "PC - 98" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 26, Value = "PC - 98 - Hireso" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 27, Value = "PC - H98" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 28, Value = "Video Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 29, Value = "Audio Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 30, Value = "Modem Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 31, Value = "Network Port" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 32, Value = "8251 Compatible" });
            _devicedataKeyValue.Add(new KeyValue { DeviceName = DeviceNames.Ports, PropertyName = DeviceProps.PortConnector.PortType.ToString(), Key = 33, Value = "8251 FIFO Compatible" });
        }


        void LoadManufacturers()
        {
            _manufacturers = new List<KeyValueText>();
            _manufacturers.Add(new KeyValueText { key = "AAC", value = "AcerView" });
            _manufacturers.Add(new KeyValueText { key = "ACR", value = "Acer" });
            _manufacturers.Add(new KeyValueText { key = "AOC", value = "AOC" });
            _manufacturers.Add(new KeyValueText { key = "AIC", value = "AG Neovo" });
            _manufacturers.Add(new KeyValueText { key = "APP", value = "Apple Computer" });
            _manufacturers.Add(new KeyValueText { key = "AST", value = "AST Research" });
            _manufacturers.Add(new KeyValueText { key = "AUO", value = "Asus" });
            _manufacturers.Add(new KeyValueText { key = "BNQ", value = "BenQ" });
            _manufacturers.Add(new KeyValueText { key = "CMO", value = "Acer" });
            _manufacturers.Add(new KeyValueText { key = "CPL", value = "Compal" });
            _manufacturers.Add(new KeyValueText { key = "CPQ", value = "Compaq" });
            _manufacturers.Add(new KeyValueText { key = "CPT", value = "Chunghwa Pciture Tubes, Ltd." });
            _manufacturers.Add(new KeyValueText { key = "CTX", value = "CTX" });
            _manufacturers.Add(new KeyValueText { key = "DEC", value = "DEC" });
            _manufacturers.Add(new KeyValueText { key = "DEL", value = "Dell" });
            _manufacturers.Add(new KeyValueText { key = "DPC", value = "Delta" });
            _manufacturers.Add(new KeyValueText { key = "DWE", value = "Daewoo" });
            _manufacturers.Add(new KeyValueText { key = "EIZ", value = "EIZO" });
            _manufacturers.Add(new KeyValueText { key = "ELS", value = "ELSA" });
            _manufacturers.Add(new KeyValueText { key = "ENC", value = "EIZO" });
            _manufacturers.Add(new KeyValueText { key = "EPI", value = "Envision" });
            _manufacturers.Add(new KeyValueText { key = "FCM", value = "Funai" });
            _manufacturers.Add(new KeyValueText { key = "FUJ", value = "Fujitsu" });
            _manufacturers.Add(new KeyValueText { key = "FUS", value = "Fujitsu-Siemens" });
            _manufacturers.Add(new KeyValueText { key = "GSM", value = "LG Electronics" });
            _manufacturers.Add(new KeyValueText { key = "GWY", value = "Gateway 2000" });
            _manufacturers.Add(new KeyValueText { key = "HEI", value = "Hyundai" });
            _manufacturers.Add(new KeyValueText { key = "HIT", value = "Hyundai" });
            _manufacturers.Add(new KeyValueText { key = "HSL", value = "Hansol" });
            _manufacturers.Add(new KeyValueText { key = "HTC", value = "Hitachi/Nissei" });
            _manufacturers.Add(new KeyValueText { key = "HWP", value = "HP" });
            _manufacturers.Add(new KeyValueText { key = "IBM", value = "IBM" });
            _manufacturers.Add(new KeyValueText { key = "ICL", value = "Fujitsu ICL" });
            _manufacturers.Add(new KeyValueText { key = "IVM", value = "Iiyama" });
            _manufacturers.Add(new KeyValueText { key = "KDS", value = "Korea Data Systems" });
            _manufacturers.Add(new KeyValueText { key = "LEN", value = "Lenovo" });
            _manufacturers.Add(new KeyValueText { key = "LGD", value = "Asus" });
            _manufacturers.Add(new KeyValueText { key = "LPL", value = "Fujitsu" });
            _manufacturers.Add(new KeyValueText { key = "MAX", value = "Belinea" });
            _manufacturers.Add(new KeyValueText { key = "MEI", value = "Panasonic" });
            _manufacturers.Add(new KeyValueText { key = "MEL", value = "Mitsubishi Electronics" });
            _manufacturers.Add(new KeyValueText { key = "MS_", value = "Panasonic" });
            _manufacturers.Add(new KeyValueText { key = "NAN", value = "Nanao" });
            _manufacturers.Add(new KeyValueText { key = "NEC", value = "NEC" });
            _manufacturers.Add(new KeyValueText { key = "NOK", value = "Nokia Data" });
            _manufacturers.Add(new KeyValueText { key = "NVD", value = "Fujitsu" });
            _manufacturers.Add(new KeyValueText { key = "OPT", value = "Optoma" });
            _manufacturers.Add(new KeyValueText { key = "PHL", value = "Philips" });
            _manufacturers.Add(new KeyValueText { key = "REL", value = "Relisys" });
            _manufacturers.Add(new KeyValueText { key = "SAN", value = "Samsung" });
            _manufacturers.Add(new KeyValueText { key = "SAM", value = "Samsung" });
            _manufacturers.Add(new KeyValueText { key = "SBI", value = "Smarttech" });
            _manufacturers.Add(new KeyValueText { key = "SGI", value = "SGI" });
            _manufacturers.Add(new KeyValueText { key = "SNY", value = "Sony" });
            _manufacturers.Add(new KeyValueText { key = "SRC", value = "Shamrock" });
            _manufacturers.Add(new KeyValueText { key = "SUN", value = "Sun Microsystems" });
            _manufacturers.Add(new KeyValueText { key = "SEC", value = "Hewlett-Packard" });
            _manufacturers.Add(new KeyValueText { key = "TAT", value = "Tatung" });
            _manufacturers.Add(new KeyValueText { key = "TOS", value = "Toshiba" });
            _manufacturers.Add(new KeyValueText { key = "TSB", value = "Toshiba" });
            _manufacturers.Add(new KeyValueText { key = "VSC", value = "ViewSonic" });
            _manufacturers.Add(new KeyValueText { key = "ZCM", value = "Zenith" });
            _manufacturers.Add(new KeyValueText { key = "UNK", value = "Unknown" });
            _manufacturers.Add(new KeyValueText { key = "_YV", value = "Fujitsu" });
        }
        public string GetMasterKeyValue(DeviceNames deviceName, string propertyName, string Key)
        {
            int _key;
            if (!int.TryParse(Key.Trim(), out _key))
                return Key;
            var reslt = _devicedataKeyValue.FirstOrDefault(x => x.DeviceName == deviceName && x.PropertyName == propertyName && x.Key == _key);
            if (reslt == null)
                return "unknown value";
            else
                return reslt.Value;
        }
        public string GetManufacurerName(string code)
        {

            var reslt = _manufacturers.FirstOrDefault(x => x.key == code);
            if (reslt == null)
                return code;
            else
                return reslt.value;
        }
    }

    //temporaray code
    class tempDbContext
    {
        static tempData _Database { get; set; }
        public static tempData DataBase
        {
            get
            {
                if (_Database == null)
                    _Database = new tempData();
                return _Database;
            }
        }
    }
}
