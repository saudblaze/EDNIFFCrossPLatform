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
        BluetoothService objBluetoothService;
        CameraService objCameraService;
        SDCardService objSDCardService;

        public SystemInfo()
        {
            //observations = new Dictionary<int, string>();

            objHardwareService = new HardwareService();
            objAudioService = new AudioService();
            objMemoryService = new MemoryService();
            objBluetoothService = new BluetoothService();
            objCameraService = new CameraService();
            objSDCardService = new SDCardService();
            devices = new List<Device>();

        }
        #region --private methods--
        public void LoadDevices()
        {
            LoadHardware();            
            LoadMemory();
            LoadAudio();
            LoadBluetooth();
            LoadCamera();
            LoadSDCard();
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
        private void LoadBluetooth()
        {
            objBluetoothService.GetBluetooth();
        }
        private void LoadCamera()
        {
            objCameraService.GetBluetooth();
        }
        private void LoadSDCard()
        {
            objSDCardService.GetSDCard();
        }

        #endregion

    }
}
