using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class HardwareDevice
    {
        public string Name { get; set; }
        //public string Caption { get; set; }
        //public string Manufacturer { get; set; }
        //public string Description { get; set; }
        //public string PNPClass { get; set; }
        //public string DeviceId { get; set; }
        //public string HardwareId { get; set; }
        //public string PNPDeviceId { get; set; }
        //public string Status { get; set; }
        //public bool Present { get; set; }
        public List<HardwareProperty> Properties { get; set; }
        public HardwareDevice()
        {
            Properties = new List<HardwareProperty>();
        }
    }

    public class HardwareProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
        //public bool isValueArray { get; set; }
        //public string[] ValueArray { get; set; }
    }
}
