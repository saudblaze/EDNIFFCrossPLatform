using EDNIFF.BusinessLogic;
using EDNIFF.Models;
using System.Collections.Generic;

namespace EDNIFF.Common
{
    public class SystemInfo
    {
        public List<Device> devices;
        


        HardwareService objHardwareService;
        AudioService objAudioService;
        

        public SystemInfo()
        {
            //observations = new Dictionary<int, string>();

            objHardwareService = new HardwareService();
            objAudioService = new AudioService();

            

        }
        #region --private methods--
        public void LoadDevices()
        {
            LoadHardware();
            LoadAudio();
        }        

        private void LoadHardware()
        {
            objHardwareService.GetHardware();
        }

        private void LoadAudio()
        {
            objAudioService.GetAudio();
        }

        #endregion

    }
}
