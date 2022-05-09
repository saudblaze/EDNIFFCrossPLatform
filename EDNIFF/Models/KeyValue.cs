using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;

namespace EDNIFF.Models
{
    public class KeyValue
    {
        public DeviceNames DeviceName { get; set; }
        public string PropertyName { get; set; }
        public int Key { get; set; }
        public string Value { get; set; }
    }

    public class KeyValueText
    {
        public string key { get; set; }
        public string value { get; set; }
    }
    public class SelectItem
    {
        public long DisplayValue { get; set; }
        public string DisplayText { get; set; }
    }
}
