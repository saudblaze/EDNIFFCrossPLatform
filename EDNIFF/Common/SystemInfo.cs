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
        MemoryService objMemoryService;



        public SystemInfo()
        {
            //observations = new Dictionary<int, string>();

            objHardwareService = new HardwareService();
            objAudioService = new AudioService();
            objMemoryService = new MemoryService();
            devices = new List<Device>();

        }
        #region --private methods--
        public void LoadDevices()
        {
            LoadHardware();
            LoadAudio();
            LoadMemory();
        }        

        private void LoadHardware()
        {
            objHardwareService.GetHardware();
        }

        private void LoadAudio()
        {
            objAudioService.GetAudio();
        }

        private void LoadMemory()
        {
            objMemoryService.GetMemory();
        }

        #endregion

    }
}
