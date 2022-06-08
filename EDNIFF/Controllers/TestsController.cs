using EDNIFF.BusinessLogic;
using EDNIFF.Common;
using EDNIFF.Models;
using EDNIFF.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Controllers
{
    public class TestsController : Controller
    {
        TestServices objTestServices;

        public TestsController()
        {
            objTestServices = new TestServices();
        }
        public IActionResult Index()
        {
            TestVM objTestList = GetTestCheckBox();

            //MacinfoVM objMacinfoVM = new MacinfoVM();
            //objMacinfoVM = MacInfo.MapMacInfoVM();

            return View(objTestList);
        }

        public TestVM GetTestCheckBox()
        {
            TestVM objTestList = new TestVM();
            objTestList.TestList = new List<TestList>();


            //condition for each test whether it is present or not


            //Sound
            TestList objTestCMOS = new TestList();
            objTestCMOS.TestName = "CMOS";
            objTestCMOS.TestLable = "CMOS";
            objTestCMOS.TestResultLable = "Optional";
            objTestCMOS.TestDone = false;
            objTestCMOS.TestSelected = false;
            objTestCMOS.TestIndex = 0;
            objTestCMOS.ClassName = "NotTestedText";
            objTestCMOS.TestResult = "NotTested";
            objTestList.TestList.Add(objTestCMOS);


            //Sound
            TestList objTestSound = new TestList();
            objTestSound.TestName = "Sound";
            objTestSound.TestLable = "Sound";
            objTestSound.TestResultLable = "Optional";
            objTestSound.TestDone = false;
            objTestSound.TestSelected = false;
            objTestSound.TestIndex = 1;
            objTestSound.ClassName = "NotTestedText";
            objTestSound.TestResult = "NotTested";
            objTestList.TestList.Add(objTestSound);

            //USB
            TestList objTestUSB = new TestList();
            objTestUSB.TestName = "USB";
            objTestUSB.TestLable = "USB";
            objTestUSB.TestResultLable = "Optional";
            objTestUSB.TestDone = false;
            objTestUSB.TestSelected = false;
            objTestUSB.TestIndex = 2;
            objTestUSB.ClassName = "NotTestedText";
            objTestUSB.TestResult = "NotTested";
            objTestList.TestList.Add(objTestUSB);

            //LanPort
            TestList objTestLanPort = new TestList();
            objTestLanPort.TestName = "LanPort";
            objTestLanPort.TestLable = "Lan Port";
            objTestLanPort.TestResultLable = "Optional";
            objTestLanPort.TestDone = false;
            objTestLanPort.TestSelected = false;
            objTestLanPort.TestIndex = 3;
            objTestLanPort.ClassName = "NotTestedText";
            objTestLanPort.TestResult = "NotTested";
            objTestList.TestList.Add(objTestLanPort);

            //Optical
            TestList objTestOptical = new TestList();
            objTestOptical.TestName = "Optical";
            objTestOptical.TestLable = "Optical";
            objTestOptical.TestResultLable = "Optional";
            objTestOptical.TestDone = false;
            objTestOptical.TestSelected = false;
            objTestOptical.TestIndex = 4;
            objTestOptical.ClassName = "NotTestedText";
            objTestOptical.TestResult = "NotTested";
            objTestList.TestList.Add(objTestOptical);

            //LCD
            TestList objTestLCD = new TestList();
            objTestLCD.TestName = "LCD";
            objTestLCD.TestLable = "LCD";
            objTestLCD.TestResultLable = "Optional";
            objTestLCD.TestDone = false;
            objTestLCD.TestSelected = false;
            objTestLCD.TestIndex = 5;
            objTestLCD.ClassName = "NotTestedText";
            objTestLCD.TestResult = "NotTested";
            objTestList.TestList.Add(objTestLCD);

            //Keyboard
            TestList objTestKeyboard = new TestList();
            objTestKeyboard.TestName = "Keyboard";
            objTestKeyboard.TestLable = "Keyboard";
            objTestKeyboard.TestResultLable = "Optional";
            objTestKeyboard.TestDone = false;
            objTestKeyboard.TestSelected = false;
            objTestKeyboard.TestIndex = 6;
            objTestKeyboard.ClassName = "NotTestedText";
            objTestKeyboard.TestResult = "NotTested";
            objTestList.TestList.Add(objTestKeyboard);

            //Touchpad
            TestList objTestTouchpad = new TestList();
            objTestTouchpad.TestName = "Touchpad";
            objTestTouchpad.TestLable = "Touchpad";
            objTestTouchpad.TestResultLable = "Optional";
            objTestTouchpad.TestDone = false;
            objTestTouchpad.TestSelected = false;
            objTestTouchpad.TestIndex = 7;
            objTestTouchpad.ClassName = "NotTestedText";
            objTestTouchpad.TestResult = "NotTested";
            objTestList.TestList.Add(objTestTouchpad);

            //Wifi
            TestList objTestWifi = new TestList();
            objTestWifi.TestName = "Wifi";
            objTestWifi.TestLable = "Wifi / Blue";
            objTestWifi.TestResultLable = "Optional";
            objTestWifi.TestDone = false;
            objTestWifi.TestSelected = false;
            objTestWifi.TestIndex = 8;
            objTestWifi.ClassName = "NotTestedText";
            objTestWifi.TestResult = "NotTested";
            objTestList.TestList.Add(objTestWifi);

            //Battery
            TestList objTestBattery = new TestList();
            objTestBattery.TestName = "Battery";
            objTestBattery.TestLable = "Battery";
            objTestBattery.TestResultLable = "Optional";
            objTestBattery.TestDone = false;
            objTestBattery.TestSelected = false;
            objTestBattery.TestIndex = 9;
            objTestBattery.ClassName = "NotTestedText";
            objTestBattery.TestResult = "NotTested";
            objTestList.TestList.Add(objTestBattery);

            //Camera
            TestList objTestCamera = new TestList();
            objTestCamera.TestName = "Camera";
            objTestCamera.TestLable = "Camera";
            objTestCamera.TestResultLable = "Optional";
            objTestCamera.TestDone = false;
            objTestCamera.TestSelected = false;
            objTestCamera.TestIndex = 10;
            objTestCamera.ClassName = "NotTestedText";
            objTestCamera.TestResult = "NotTested";
            objTestList.TestList.Add(objTestCamera);

            //TouchScreen
            TestList objTestTouchScreen = new TestList();
            objTestTouchScreen.TestName = "TouchScreen";
            objTestTouchScreen.TestLable = "TouchScreen";
            objTestTouchScreen.TestResultLable = "Optional";
            objTestTouchScreen.TestDone = false;
            objTestTouchScreen.TestSelected = false;
            objTestTouchScreen.TestIndex = 11;
            objTestTouchScreen.ClassName = "NotTestedText";
            objTestTouchScreen.TestResult = "NotTested";
            objTestList.TestList.Add(objTestTouchScreen);


            //Microphone
            TestList objTestMicrophone = new TestList();
            objTestMicrophone.TestName = "Microphone";
            objTestMicrophone.TestLable = "Microphone";
            objTestMicrophone.TestResultLable = "Optional";
            objTestMicrophone.TestDone = false;
            objTestMicrophone.TestSelected = false;
            objTestMicrophone.TestIndex = 12;
            objTestMicrophone.ClassName = "NotTestedText";
            objTestMicrophone.TestResult = "NotTested";
            objTestList.TestList.Add(objTestMicrophone);

            //SDCard
            TestList objTestSDCard = new TestList();
            objTestSDCard.TestName = "SDCard";
            objTestSDCard.TestLable = "SD Card Test";
            objTestSDCard.TestResultLable = "Optional";
            objTestSDCard.TestDone = false;
            objTestSDCard.TestSelected = false;
            objTestSDCard.TestIndex = 13;
            objTestSDCard.ClassName = "NotTestedText";
            objTestSDCard.TestResult = "NotTested";
            objTestList.TestList.Add(objTestSDCard);

            //Biometric
            TestList objTestBiometric = new TestList();
            objTestBiometric.TestName = "Biometric";
            objTestBiometric.TestLable = "Biometric";
            objTestBiometric.TestResultLable = "Optional";
            objTestBiometric.TestDone = false;
            objTestBiometric.TestSelected = false;
            objTestBiometric.TestIndex = 14;
            objTestBiometric.ClassName = "NotTestedText";
            objTestBiometric.TestResult = "NotTested";
            objTestList.TestList.Add(objTestBiometric);

            //SmartCard
            TestList objTestSmartCard = new TestList();
            objTestSmartCard.TestName = "SmartCard";
            objTestSmartCard.TestLable = "Smart Card";
            objTestSmartCard.TestResultLable = "Optional";
            objTestSmartCard.TestDone = false;
            objTestSmartCard.TestSelected = false;
            objTestSmartCard.TestIndex = 15;
            objTestSmartCard.ClassName = "NotTestedText";
            objTestSmartCard.TestResult = "NotTested";
            objTestList.TestList.Add(objTestSmartCard);

            //Display
            TestList objTestDisplay = new TestList();
            objTestDisplay.TestName = "Display";
            objTestDisplay.TestLable = "Display";
            objTestDisplay.TestResultLable = "Optional";
            objTestDisplay.TestDone = false;
            objTestDisplay.TestSelected = false;
            objTestDisplay.TestIndex = 16;
            objTestDisplay.ClassName = "NotTestedText";
            objTestDisplay.TestResult = "NotTested";
            objTestList.TestList.Add(objTestDisplay);

            //PortTest
            TestList objTestPortTest = new TestList();
            objTestPortTest.TestName = "PortTest";
            objTestPortTest.TestLable = "Port Test";
            objTestPortTest.TestResultLable = "Optional";
            objTestPortTest.TestDone = false;
            objTestPortTest.TestSelected = false;
            objTestPortTest.TestIndex = 17;
            objTestPortTest.ClassName = "NotTestedText";
            objTestPortTest.TestResult = "NotTested";
            objTestList.TestList.Add(objTestPortTest);

            return objTestList;
        }

        public ActionResult DisplaySearchResults()
        {

            return PartialView("~/PartialViews/SoundTest.cshtml");
        }

        public JsonResult GetTestHtml(TestList obj)
        {

            if (obj != null)
            {
                string strResult = getTestView(obj.TestName);
                return Json(new { data = strResult, IsSuccess = 1 });
            }
            else
            {
                return Json(new { data = "", IsSuccess = 0 });
            }
        }


        public JsonResult MarkTestComplete(TestList obj)
        {

            if (obj != null)
            {
                //string strResult = getTestView(obj.TestName);

                foreach (Device item in MacInfo.devices)
                {
                    if (item.TestName == obj.TestName)
                    {
                        item.TestDone = true;
                    }
                }

                return Json(new { IsSuccess = 1 });
            }
            else
            {
                return Json(new { IsSuccess = 0 });
            }
        }

        public JsonResult SetGradeMethod(SetGrade obj)
        {

            if (obj != null)
            {
                MacInfo.Grade = obj.Grade;

                return Json(new { IsSuccess = 1 });
            }
            else
            {
                return Json(new { IsSuccess = 0 });
            }
        }

        public async Task<JsonResult> MainSaveMethodAsync(MainSaveMethodParam obj)
        {

            if (obj != null)
            {
                var objResult = await objTestServices.SaveMethod(obj);
                return Json(new { IsSuccess = 1 });
            }
            else
            {
                return Json(new { IsSuccess = 0 });
            }
        }

        public string getTestView(string TestName)
        {


            string strResult = string.Empty;

            switch (TestName)
            {
                case "CMOS":
                    Device objDeviceCMOS = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetCMOSString(objDeviceCMOS);
                    break;
                case "Sound":
                    Device objDeviceSound = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetSoundString(objDeviceSound);
                    break;
                case "USB":
                    Device objDeviceUSB = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetUSB(objDeviceUSB);
                    break;
                case "LanPort":
                    Device objDeviceLanPort = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetLanPort(objDeviceLanPort);
                    break;
                case "Optical":
                    Device objDeviceOptical = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetOptical(objDeviceOptical);
                    break;
                case "LCD":
                    Device objDeviceLCD = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetLCD(objDeviceLCD);
                    break;
                case "Keyboard":
                    Device objDeviceKeyboard = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetKeyboard(objDeviceKeyboard);
                    break;
                case "Touchpad":
                    Device objDeviceTouchpad = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetTouchpad(objDeviceTouchpad);
                    break;
                case "Wifi":
                    Device objDeviceWifi = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetWifi(objDeviceWifi);
                    break;
                case "Battery":
                    Device objDeviceBattery = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetBattery(objDeviceBattery);
                    break;
                case "Camera":
                    Device objDeviceCamera = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetCamera(objDeviceCamera);
                    break;
                case "TouchScreen":
                    Device objDeviceTouchScreen = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetTouchScreen(objDeviceTouchScreen);
                    break;
                case "Microphone":
                    Device objDeviceMicrophone = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetMicrophone(objDeviceMicrophone);
                    break;
                case "SDCard":
                    Device objDeviceSDCard = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetSDCard(objDeviceSDCard);
                    break;
                case "Biometric":
                    Device objDeviceBiometric = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetBiometric(objDeviceBiometric);
                    break;
                case "SmartCard":
                    Device objDeviceSmartCard = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetSmartCard(objDeviceSmartCard);
                    break;
                case "Display":
                    Device objDeviceDisplay = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetDisplay(objDeviceDisplay);
                    break;
                case "PortTest":
                    Device objDevicePortTest = MacInfo.devices.Where(x => x.TestName == TestName).FirstOrDefault();
                    strResult = GetPortTest(objDevicePortTest);
                    break;
                default:
                    break;
            }


            return strResult;
        }

        public string GetCMOSString(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +
                        "<tr>" +
                        "<td> SMC Version </td>" +
                        "<td>" + objDevice.Model + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td> System Firmware Version </td>" +
                        "<td>" + objDevice.Serial + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td> Model Identifier </td>" +
                        "<td>" + objDevice.Info1 + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td> Model </td>" +
                        "<td>" + objDevice.Info2 + "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='CMOS' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='CMOS' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetSoundString(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td class='td50 AllignCenter'><img src='~/Images/Left.png' alt='No image found' /> </td>" +
                        "<td class='td50 AllignCenter'><img src='~/Images/Right.png' alt='No image found' />  </td>" +
                        "</tr>" +


                        "<tr>" +
                        "<td class='td50 Allignleft'> <button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; ' id='btnLeftSpeaker' onclick='Sound.LeftSpeakerTest()'>Left</button> </td>" +
                        "<td class='td50 Allignleft'> <button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; ' id='btnRightSpeaker' onclick='Sound.RightSpeakerTest()'>Right</button></td>" +
                        "</tr>" +

                        "<tr>" +
                            "<td class='td50 Allignleft'> " +
                                "<div class='form-check form-check-inline'>" +
                                    "<input class='form-check-input' type='radio' name='LeftSpeaker' id='chkLeftSpeakerPass' onchange='Sound.LeftSpeakerChange(\"Pass\")' value='Pass' >" +
                                    "<label class='form-check-label'>Pass</label>" +
                                "</div>" +
                                "<div class='form-check form-check-inline'>" +
                                    "<input class='form-check-input' type='radio' name='LeftSpeaker' id='chkLeftSpeakerFail' onchange='Sound.LeftSpeakerChange(\"Fail\")' value='Fail' >" +
                                    "<label class='form-check-label'>Fail</label>" +
                                "</div>" +
                            "</td>" +
                            "<td class='td50 Allignleft'>" +
                                "<div class='form-check form-check-inline'>" +
                                    "<input class='form-check-input' type='radio' name='RightSpeaker' id='chkRightSpeakerPass' onchange='Sound.RightSpeakerChange(\"Pass\")' value='Pass' >" +
                                    "<label class='form-check-label'>Pass</label>" +
                                "</div>" +
                                "<div class='form-check form-check-inline'>" +
                                    "<input class='form-check-input' type='radio' name='RightSpeaker' id='chkRightSpeakerFail' onchange='Sound.RightSpeakerChange(\"Fail\")' value='Fail' >" +
                                    "<label class='form-check-label'>Fail</label>" +
                                "</div>" +
                            "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td class='td50 Allignleft'> Result </td>" +
                        "<td class='td50 Allignleft'>" +
                            "<div class='form-check paddingleft'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td class='td50 Allignleft'> Audio Port </td>" +
                        "<td class='td50 Allignleft'>" +
                            "<div style='display:flex;'>" +
                                "<div class='form-check paddingleft'>" +
                                    "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                                "</div>" +
                                "<div class='form-check form-check-inline marginleft10' >" +
                                    "<input class='form-check-input' type='radio' id='Pass' name='AudioPort' onchange='Sound.AudioPortChange(\"Pass\")' value='Pass' >" +
                                    "<label class='form-check-label'>Pass</label>" +
                                "</div>" +
                                "<div class='form-check form-check-inline marginleft10' >" +
                                    "<input class='form-check-input' type='radio' id='Fail' name='AudioPort' onchange='Sound.AudioPortChange(\"Fail\")' value='Fail' >" +
                                    "<label class='form-check-label'>Fail</label>" +
                                "</div>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td class='td50 Allignleft'> Comments </td>" +
                        "<td class='td50 Allignleft'>" +
                            "<div class='form-check paddingleft'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetUSB(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {

                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +




                        "<tr>" +
                        "<td class='td50 Allignleft'> Total Number of ports to test </td>" +
                        "<td class='td50 Allignleft'>" +
                        "<div class='form-check paddingleft'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Number' placeholder=''>" +

                            "</div>" +
                        " </td>" +
                        "</tr>" +

                        "<tr>" +
                            "<td class='td50 Allignleft'> " +
                            "</td>" +
                            "<td class='td50 Allignleft'>" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; ' id='btnNext' onclick='USB.RetestUSB()'>Retest</button>" +
                            "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td class='td50 Allignleft'> Result </td>" +
                        "<td class='td50 Allignleft'>" +
                            "<div class='form-check paddingleft'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td class='td50 Allignleft'>  </td>" +
                        "<td class='td50 Allignleft'>" +
                                "<div class='form-check form-check-inline marginleft10' >" +
                                    "<input class='form-check-input' type='radio' id='Pass' name='AudioPort' onchange='USB.USBChange(\"Pass\")' value='Pass' >" +
                                    "<label class='form-check-label'>Pass</label>" +
                                "</div>" +
                                "<div class='form-check form-check-inline marginleft10' >" +
                                    "<input class='form-check-input' type='radio' id='Fail' name='AudioPort' onchange='USB.USBChange(\"Fail\")' value='Fail' >" +
                                    "<label class='form-check-label'>Fail</label>" +
                                "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td class='td50 Allignleft'> Comments </td>" +
                        "<td class='td50 Allignleft'>" +
                            "<div class='form-check paddingleft'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";

            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetLanPort(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +
                        "<tr>" +
                        "<td> Lan adaptor name </td>" +
                        "<td>" + objDevice.Model + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td> Description </td>" +
                        "<td>" + objDevice.Serial + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td> Interface type </td>" +
                        "<td>" + objDevice.Info1 + "</td>" +
                        "</tr>" +
                        "<tr>" +
                        "<td> Lan Status </td>" +
                        "<td>" + objDevice.Info2 + "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Nic speed </td>" +
                        "<td>" + objDevice.Info2 + "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetOptical(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                            "<td class='td50 AllignCenter' colspan='2'><img src='~/Images/Left.png' alt='No image found' /> </td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +

                            "<div class='form-check form-check-inline'>" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btn" + objDevice.TestName + "StartTest' onclick='StartTest()'>Start Test</button>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                            "<td class='td50 AllignCenter' colspan='2'><img src='~/Images/Left.png' alt='No image found' /> </td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetLCD(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetKeyboard(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='checkbox' id='chk" + objDevice.TestName + "Type'  onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Numeric Keyboard</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<select class='form-select' aria-label='Default select example'> " +
                                    "<option value='EU'> EU</option>" +
                                    "<option value='US'> US</option>" +
                                "</select>" +
                            "</div>" +
                            "<div>" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='keyboard.StartTest()'>Start test</button>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> " +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='checkbox' id='chk" + objDevice.TestName + "Backlight'  onchange='keyboard.BacklightKeyboardChecked()' value='Pass' >" +
                                "<label class='form-check-label'>Numeric Keyboard</label>" +
                            "</div>" +
                        " </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "Backlight' onchange='keyboard.BacklightPassFail(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "Backlight' onchange='keyboard.BacklightPassFail(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetTouchpad(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td colspan='2' > " +
                            "<div class='row'>" +
                                "<div class='col' style='align-items: center; justify-content: center; display: flex;'>" +
                                    "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 150px; height:150px;' id='btnLeftTouch' onclick='Touchpad.SetTouch()'>Left Touch</button>" +
                                "</div>" +
                                "<div class='col' style='align-items: center; justify-content: center; display: flex;'>" +
                                    "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 150px; height:150px;' id='btnRightTouch' onclick='Touchpad.SetTouch()'>Right Touch</button>" +
                                "</div>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +
                        
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnResetTouch' onclick='Touchpad.ResetTouch()'>Reset Touch</button>" +
                            "</div>" +

                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td colspan='2' > " +
                            "<div class='row'>" +
                                "<div class='col' style='align-items: center; justify-content: center; display: flex;'>" +
                                    "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 120px; height:120px;' id='btnLeftTouch' onclick='Touchpad.SetPointerTouch()'>Left Button</button>" +
                                "</div>" +
                                "<div class='col' style='align-items: center; justify-content: center; display: flex;'>" +
                                    "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 120px; height:120px;' id='btnLeftTouch' onclick='Touchpad.SetPointerTouch()'>Middle Button</button>" +
                                "</div>" +
                                "<div class='col' style='align-items: center; justify-content: center; display: flex;'>" +
                                    "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 120px; height:120px;' id='btnLeftTouch' onclick='Touchpad.SetPointerTouch()'>Right Button</button>" +
                                "</div>" +
                            "</div>" +                            
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='Touchpad.MarkAsPointerCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='Touchpad.MarkAsPointerCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnResetTouchPointer' onclick='Touchpad.ResetPointerTouch()'>Reset Pointer</button>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetWifi(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetBattery(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetCamera(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetTouchScreen(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetMicrophone(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetSDCard(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetBiometric(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetSmartCard(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetDisplay(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

        public string GetPortTest(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {
                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>" + objDevice.TestName + " Test" +
                            "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                            "</th>" +
                        "</tr></thead> " +
                        "<tbody>" +

                        "<tr>" +
                        "<td>  </td>" +
                        "<td>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Pass' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='Fail' name='" + objDevice.TestName + "' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div class='form-check'>" +
                                "<input type='text' class='form-control' id='txt" + objDevice.TestName + "Comment' placeholder=''>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "</tbody>" +
                        "</table>";
            }
            else
            {
                strResult = "<table class='table'>" +
                            "<thead class='thead-dark'><tr> " +
                                "<th colspan='4'>No Object Found" +
                                "<button type='button' class='btn btn-primary btn-block btn-sm' style='width: 110px; float:right;' id='btnNext' onclick='NextClick()'>Next</button>" +
                                "</th>" +
                            "</tr></thead> " +
                            "<tbody>" +

                            "<tr>" +
                            "<td ></td>" +
                            "<td ></td>" +
                            "</tr>" +

                            "</tbody>" +
                            "</table>";
            }
            return strResult;
        }

    }
}
