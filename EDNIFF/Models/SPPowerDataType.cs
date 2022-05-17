using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class SPPowerDataType
    {
        public string Manufacturer { get; set; }
        public string DeviceName { get; set; }
        public string PackLotCode { get; set; }
        public string PCBLotCode { get; set; }
        public string FirmwareVersion { get; set; }
        public string HardwareRevision { get; set; }
        public string CellRevision { get; set; }
        public string FullyCharged { get; set; }
        public string Charging { get; set; }
        public string FullChargeCapacity { get; set; }
        public string StateOfCharge { get; set; }
        public string CycleCount { get; set; }
        public string Condition { get; set; }
    }
}
