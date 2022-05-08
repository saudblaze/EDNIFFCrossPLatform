using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class HDDSmartInfo
    {
        public int index { get; set; }
        public List<SmartInfo> smartInfos { get; set; }
    }
    public class SmartInfo
    {
        public int InfoId { get; set; }
        public string AttributeName { get; set; }
        public int ThresholdValue { get; set; }
        public int CurrentValue { get; set; }
        public int WorstValue { get; set; }
        public string Status { get; set; }
        public int Data { get; set; }
    }
}
