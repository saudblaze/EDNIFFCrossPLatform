using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class SPAudioDataType
    {
        public BuiltInMicrophone BuiltInMicrophone { get; set; }
        public BuiltInOutput BuiltInOutput { get; set; }
    }

    public class BuiltInMicrophone
    {
        public string DefaultInputDevice { get; set; }
        public string InputChannels { get; set; }
        public string Manufacturer { get; set; }
        public string CurrentSampleRate { get; set; }
        public string Transport { get; set; }
        public string InputSource { get; set; }
    }
    public class BuiltInOutput
    {
        public string DefaultOutputDevice { get; set; }
        public string DefaultSystemOutputDevice { get; set; }        
        public string Manufacturer { get; set; }
        public string OutputChannels { get; set; }
        public string CurrentSampleRate { get; set; }
        public string Transport { get; set; }
        public string OutputSource { get; set; }
    }
}
