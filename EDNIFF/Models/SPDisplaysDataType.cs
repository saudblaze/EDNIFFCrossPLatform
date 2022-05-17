using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class SPDisplaysDataType
    {
        public Video Video { get; set; }
        public LCD LCD1 { get; set; }
        public LCD LCD2 { get; set; }

    }
    public class Video
    {
        public string ChipsetModel { get; set; }
        public string Type { get; set; }
        public string Bus { get; set; }
        public string VRAM { get; set; }
        public string Vendor { get; set; }
        public string DeviceID { get; set; }
        public string RevisionID { get; set; }
        public string MetalFamily { get; set; }
    }
    public class LCD
    {
        public string DisplayType { get; set; }
        public string Resolution { get; set; }
        public string UILooksLike { get; set; }
        public string FramebufferDepth { get; set; }
        public string MainDisplay { get; set; }
        public string Mirror { get; set; }
        public string Online { get; set; }
        public string AutomaticallyAdjustBrightness { get; set; }
        public string ConnectionType { get; set; }
    }
}
