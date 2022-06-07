using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.ViewModel
{
    public class DashboardVM
    {
        public string ModelName { get; set; }
        public string ModelIdentifier { get; set; }
        public string ProcessorName { get; set; }
        public string ProcessorSpeed { get; set; }
        public string NumberOfProcessors { get; set; }
        public string TotalNumberOfCores { get; set; }
        public string L2Cache { get; set; }
        public string L3Cache { get; set; }
        public string HyperThreadingTechnology { get; set; }
        public string Memory { get; set; }
        public string SystemFirmwareVersion { get; set; }
        public string SMCVersion { get; set; }
        public string SerialNumber { get; set; }
        public string HardwareUUID { get; set; }
        public string ProvisioningUDID { get; set; }


        public string OSCOA { get; set; }

        public string Resolution { get; set; }

        public string Grade { get; set; }
        
    }
}
