using EDNIFF.BusinessLogic;
using EDNIFF.Models;
using System.Collections.Generic;
using System.Linq;
using static EDNIFF.Helpers.ConstantData;

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
        GraphicsService objGraphicsService;
        BatteryService objBatteryService;
        StorageService objStorageService;
        USBService objUSBService;
        NetworkService objNetworkService;
        WifiService objWifiService;
        public SystemInfo()
        {
            //observations = new Dictionary<int, string>();

            objHardwareService = new HardwareService();
            objAudioService = new AudioService();
            objMemoryService = new MemoryService();
            objBluetoothService = new BluetoothService();
            objCameraService = new CameraService();
            objSDCardService = new SDCardService();
            objGraphicsService = new GraphicsService();
            objBatteryService = new BatteryService();
            objStorageService = new StorageService();
            objUSBService = new USBService();
            objNetworkService = new NetworkService();
            objWifiService = new WifiService();
            devices = new List<Device>();

        }
        #region --private methods--
        public void LoadDevices()
        {
            LoadHardware();  
            LoadAudio();
            LoadMemory();
            LoadBluetooth();
            LoadCamera();
            LoadSDCard();
            LoadGraphics();
            LoadBattery();
            LoadStorage();
            LoadUSB();
            LoadNetwork();
            LoadWifi();
            LoadDiscBurning();
            LoadKeyboard();
            LoadTouchpad();
            LoadTouchScreen();
            LoadBiometric();
            LoadSmartCard();
            LoadPortTest();
        }        

        private void LoadHardware()
        {
            objHardwareService.GetHardware();
        }
        private void LoadBiometric()
        {
            objHardwareService.GetBiometric();
        }
        private void LoadSmartCard()
        {
            objHardwareService.GetSmartCard();
        }
        private void LoadPortTest()
        {
            objHardwareService.GetPortTest();
        }
        private void LoadDiscBurning()
        {
            objHardwareService.GetDiscBurning();
        }
        private void LoadKeyboard()
        {
            objHardwareService.GetKeyboard();
        }
        private void LoadTouchpad()
        {
            objHardwareService.GetTouchpad();
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
        private void LoadGraphics()
        {
            objGraphicsService.GetGraphics();
        }
        private void LoadTouchScreen()
        {
            objGraphicsService.GetTouchScreen();
        }
        private void LoadBattery()
        {
            objBatteryService.GetBattery();
        }
        private void LoadStorage()
        {
            objStorageService.GetStorage();
        }
        private void LoadUSB()
        {
            objUSBService.GetUSB();
        }
        private void LoadNetwork()
        {
            objNetworkService.GetNetwork();
            objNetworkService.GetEthernet();
        }
        private void LoadWifi()
        {
            objWifiService.GetWifi();
        }
        #endregion




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
