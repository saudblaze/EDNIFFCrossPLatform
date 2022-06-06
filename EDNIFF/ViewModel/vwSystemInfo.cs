using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.ViewModel
{
    public class vwSystemInfo
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public string InhouseSerialNo { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public string ProcGen { get; set; }
        public string ProcSpeed { get; set; }
        public string RAM { get; set; }
        public string StorageSize { get; set; }
        public string StorageType { get; set; }
        //public string BatteryHealth { get; set; }
        public string Resolution { get; set; }
        public string COA { get; set; }
        public string DisplaySize { get; set; }
        public string MADEIN { get; set; }
        public string GRADE { get; set; }
        public string Keyboard { get; set; }
        //public string MACADD { get; set; }
        //public string createdBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        public string CreatedOn { get; set; }
        //public DateTime? updatedOn { get; set; }
        //public string updatedBy { get; set; }
        //public string ExpandedCodes 1st Audit { get; set; }
        //public string ExpandedCodes 2nd Audit { get; set; }

        public string UUID { get; set; }
        public string MACADD { get; set; }
    }
}
