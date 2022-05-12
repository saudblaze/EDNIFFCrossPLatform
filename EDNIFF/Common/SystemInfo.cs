using EDNIFF.BusinessLogic;
using EDNIFF.BussinessLogic;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Common
{
    public class SystemInfo
    {
        public List<Device> devices;
        public MacInfo MacInfo;


        HardwareService objHardwareService;
        AudioService objAudioService;
        

        public SystemInfo()
        {
            //observations = new Dictionary<int, string>();

            objHardwareService = new HardwareService();
            objAudioService = new AudioService();

            MacInfo = new MacInfo();

        }
        #region --private methods--
        public void LoadDevices()
        {
            LoadHardware();
            LoadAudio();
        }        

        private void LoadHardware()
        {
            objHardwareService.GetHardware(MacInfo);
        }

        private void LoadAudio()
        {
            objAudioService.GetAudio(MacInfo)
        }

        #endregion

    }
}
