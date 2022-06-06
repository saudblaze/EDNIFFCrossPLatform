using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;

namespace EDNIFF.Common
{
    public class CommonMethods
    {
        public Device GetDevice(Categories Categories, DeviceNames DeviceName)
        {
            Device objReturn = new Device();
            if (MacInfo.devices != null && MacInfo.devices.Count > 0)
            {
                objReturn = MacInfo.devices.Where(x => x.Category == Categories && x.DeviceName == DeviceName).FirstOrDefault();
            }
            return objReturn;
        }
    }
    
}
