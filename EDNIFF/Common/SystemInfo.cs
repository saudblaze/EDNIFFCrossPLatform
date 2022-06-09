using EDNIFF.BusinessLogic;
using EDNIFF.Models;
using EDNIFF.ViewModel;
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
            SetTestList();
        }        

        private void LoadHardware()
        {
            objHardwareService.GetHardware();
            objHardwareService.GetOSCOA();
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
            objCameraService.GetCamera();
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

        private void SetTestList()
        {
            //TestVM objTestList = new TestVM();

            List<TestList> objTestList = new List<TestList>();

            //Sound
            TestList objTestCMOS = new TestList();
            objTestCMOS.testName = "CMOS";
            objTestCMOS.testLable = "CMOS";
            objTestCMOS.testResultLable = "Optional";
            objTestCMOS.testDone = false;
            objTestCMOS.testSelected = false;
            objTestCMOS.testIndex = 0;
            objTestCMOS.className = "NotTestedText";
            objTestCMOS.testResult = "NotTested";
            objTestList.Add(objTestCMOS);


            //Sound
            TestList objTestSound = new TestList();
            objTestSound.testName = "Sound";
            objTestSound.testLable = "Sound";
            objTestSound.testResultLable = "Optional";
            objTestSound.testDone = false;
            objTestSound.testSelected = false;
            objTestSound.testIndex = 1;
            objTestSound.className = "NotTestedText";
            objTestSound.testResult = "NotTested";
            objTestList.Add(objTestSound);

            //USB
            TestList objTestUSB = new TestList();
            objTestUSB.testName = "USB";
            objTestUSB.testLable = "USB";
            objTestUSB.testResultLable = "Optional";
            objTestUSB.testDone = false;
            objTestUSB.testSelected = false;
            objTestUSB.testIndex = 2;
            objTestUSB.className = "NotTestedText";
            objTestUSB.testResult = "NotTested";
            objTestList.Add(objTestUSB);

            //LanPort
            TestList objTestLanPort = new TestList();
            objTestLanPort.testName = "LanPort";
            objTestLanPort.testLable = "Lan Port";
            objTestLanPort.testResultLable = "Optional";
            objTestLanPort.testDone = false;
            objTestLanPort.testSelected = false;
            objTestLanPort.testIndex = 3;
            objTestLanPort.className = "NotTestedText";
            objTestLanPort.testResult = "NotTested";
            objTestList.Add(objTestLanPort);

            //Optical
            TestList objTestOptical = new TestList();
            objTestOptical.testName = "Optical";
            objTestOptical.testLable = "Optical";
            objTestOptical.testResultLable = "Optional";
            objTestOptical.testDone = false;
            objTestOptical.testSelected = false;
            objTestOptical.testIndex = 4;
            objTestOptical.className = "NotTestedText";
            objTestOptical.testResult = "NotTested";
            objTestList.Add(objTestOptical);

            //LCD
            TestList objTestLCD = new TestList();
            objTestLCD.testName = "LCD";
            objTestLCD.testLable = "LCD";
            objTestLCD.testResultLable = "Optional";
            objTestLCD.testDone = false;
            objTestLCD.testSelected = false;
            objTestLCD.testIndex = 5;
            objTestLCD.className = "NotTestedText";
            objTestLCD.testResult = "NotTested";
            objTestList.Add(objTestLCD);

            //Keyboard
            TestList objTestKeyboard = new TestList();
            objTestKeyboard.testName = "Keyboard";
            objTestKeyboard.testLable = "Keyboard";
            objTestKeyboard.testResultLable = "Optional";
            objTestKeyboard.testDone = false;
            objTestKeyboard.testSelected = false;
            objTestKeyboard.testIndex = 6;
            objTestKeyboard.className = "NotTestedText";
            objTestKeyboard.testResult = "NotTested";
            objTestList.Add(objTestKeyboard);

            //Touchpad
            TestList objTestTouchpad = new TestList();
            objTestTouchpad.testName = "Touchpad";
            objTestTouchpad.testLable = "Touchpad";
            objTestTouchpad.testResultLable = "Optional";
            objTestTouchpad.testDone = false;
            objTestTouchpad.testSelected = false;
            objTestTouchpad.testIndex = 7;
            objTestTouchpad.className = "NotTestedText";
            objTestTouchpad.testResult = "NotTested";
            objTestList.Add(objTestTouchpad);

            //Wifi
            TestList objTestWifi = new TestList();
            objTestWifi.testName = "Wifi";
            objTestWifi.testLable = "Wifi / Blue";
            objTestWifi.testResultLable = "Optional";
            objTestWifi.testDone = false;
            objTestWifi.testSelected = false;
            objTestWifi.testIndex = 8;
            objTestWifi.className = "NotTestedText";
            objTestWifi.testResult = "NotTested";
            objTestList.Add(objTestWifi);

            //Battery
            TestList objTestBattery = new TestList();
            objTestBattery.testName = "Battery";
            objTestBattery.testLable = "Battery";
            objTestBattery.testResultLable = "Optional";
            objTestBattery.testDone = false;
            objTestBattery.testSelected = false;
            objTestBattery.testIndex = 9;
            objTestBattery.className = "NotTestedText";
            objTestBattery.testResult = "NotTested";
            objTestList.Add(objTestBattery);

            //Camera
            TestList objTestCamera = new TestList();
            objTestCamera.testName = "Camera";
            objTestCamera.testLable = "Camera";
            objTestCamera.testResultLable = "Optional";
            objTestCamera.testDone = false;
            objTestCamera.testSelected = false;
            objTestCamera.testIndex = 10;
            objTestCamera.className = "NotTestedText";
            objTestCamera.testResult = "NotTested";
            objTestList.Add(objTestCamera);

            //TouchScreen
            TestList objTestTouchScreen = new TestList();
            objTestTouchScreen.testName = "TouchScreen";
            objTestTouchScreen.testLable = "TouchScreen";
            objTestTouchScreen.testResultLable = "Optional";
            objTestTouchScreen.testDone = false;
            objTestTouchScreen.testSelected = false;
            objTestTouchScreen.testIndex = 11;
            objTestTouchScreen.className = "NotTestedText";
            objTestTouchScreen.testResult = "NotTested";
            objTestList.Add(objTestTouchScreen);


            //Microphone
            TestList objTestMicrophone = new TestList();
            objTestMicrophone.testName = "Microphone";
            objTestMicrophone.testLable = "Microphone";
            objTestMicrophone.testResultLable = "Optional";
            objTestMicrophone.testDone = false;
            objTestMicrophone.testSelected = false;
            objTestMicrophone.testIndex = 12;
            objTestMicrophone.className = "NotTestedText";
            objTestMicrophone.testResult = "NotTested";
            objTestList.Add(objTestMicrophone);

            //SDCard
            TestList objTestSDCard = new TestList();
            objTestSDCard.testName = "SDCard";
            objTestSDCard.testLable = "SD Card Test";
            objTestSDCard.testResultLable = "Optional";
            objTestSDCard.testDone = false;
            objTestSDCard.testSelected = false;
            objTestSDCard.testIndex = 13;
            objTestSDCard.className = "NotTestedText";
            objTestSDCard.testResult = "NotTested";
            objTestList.Add(objTestSDCard);

            //Biometric
            TestList objTestBiometric = new TestList();
            objTestBiometric.testName = "Biometric";
            objTestBiometric.testLable = "Biometric";
            objTestBiometric.testResultLable = "Optional";
            objTestBiometric.testDone = false;
            objTestBiometric.testSelected = false;
            objTestBiometric.testIndex = 14;
            objTestBiometric.className = "NotTestedText";
            objTestBiometric.testResult = "NotTested";
            objTestList.Add(objTestBiometric);

            //SmartCard
            TestList objTestSmartCard = new TestList();
            objTestSmartCard.testName = "SmartCard";
            objTestSmartCard.testLable = "Smart Card";
            objTestSmartCard.testResultLable = "Optional";
            objTestSmartCard.testDone = false;
            objTestSmartCard.testSelected = false;
            objTestSmartCard.testIndex = 15;
            objTestSmartCard.className = "NotTestedText";
            objTestSmartCard.testResult = "NotTested";
            objTestList.Add(objTestSmartCard);

            //Display
            TestList objTestDisplay = new TestList();
            objTestDisplay.testName = "Display";
            objTestDisplay.testLable = "Display";
            objTestDisplay.testResultLable = "Optional";
            objTestDisplay.testDone = false;
            objTestDisplay.testSelected = false;
            objTestDisplay.testIndex = 16;
            objTestDisplay.className = "NotTestedText";
            objTestDisplay.testResult = "NotTested";
            objTestList.Add(objTestDisplay);

            //PortTest
            TestList objTestPortTest = new TestList();
            objTestPortTest.testName = "PortTest";
            objTestPortTest.testLable = "Port Test";
            objTestPortTest.testResultLable = "Optional";
            objTestPortTest.testDone = false;
            objTestPortTest.testSelected = false;
            objTestPortTest.testIndex = 17;
            objTestPortTest.className = "NotTestedText";
            objTestPortTest.testResult = "NotTested";
            objTestList.Add(objTestPortTest);


            MacInfo.TestList = objTestList;
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
