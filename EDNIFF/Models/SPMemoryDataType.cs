using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class SPMemoryDataType
    {
        public string ECC { get; set; }
        public string UpgradeableMemory { get; set; }
        public Bank0 Bank0 { get; set; }
        public Bank1 Bank1 { get; set; }
    }

    public class Bank0
    {
        public string Size { get; set; }
        public string Type { get; set; }
        public string Speed { get; set; }
        public string Status { get; set; }
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
    }
    public class Bank1
    {
        public string Size { get; set; }
        public string Type { get; set; }
        public string Speed { get; set; }
        public string Status { get; set; }
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
    }

}
