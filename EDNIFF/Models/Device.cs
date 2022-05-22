using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;

namespace EDNIFF.Models
{
    public enum DeviceStatus
    {
        NotTested,
        //Present,
        NotPresent,
        Pass,
        Fail,
        Passbl,
        Failbl,
        Running

    }
    public class Device
    {
        public int Id { get; set; }
        public Categories Category { get; set; }
        public DeviceNames DeviceName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public string Size { get; set; }
        public string Speed { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        //public bool isTested { get; set; }

        public string Caption { get; set; }
        public string Description { get; set; }
        public string DeviceId { get; set; }
        public string HardwareId { get; set; }
        public string PNPDeviceId { get; set; }
        public string Status { get; set; }
        public bool boolInfo1 { get; set; }
        public bool boolInfo2 { get; set; }
        public string Comment { get; set; }
        public bool validation { get; set; }
        public DeviceStatus deviceStatus { get; set; }

        public bool DevicePresent
        {
            get
            {
                bool status = deviceStatus != DeviceStatus.NotPresent;
                //if (!status)
                //    System.Windows.Forms.MessageBox.Show("Device is not present");
                return status;
            }
        }
        //public List<HardwareProperty> Properties { get; set; }




        //new fields added
        public string InputId { get; set; }
        public string LableId { get; set; }
        public string TestName { get; set; }
        public string TestLable { get; set; }
        public string TestResultLable { get; set; }
        public bool TestDone { get; set; }
        public bool TestSelected { get; set; }
        public int TestIndex { get; set; }
        
    }
}
