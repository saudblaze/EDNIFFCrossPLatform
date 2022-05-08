using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class SystemPort
    {
        public string PortId { get; set; }
        public string PortType { get; set; }
        public string PortName { get; set; }
        public DeviceStatus deviceStatus { get; set; }
    }
}
