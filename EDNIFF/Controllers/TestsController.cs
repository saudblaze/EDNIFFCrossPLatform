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
            objTestList.Grade = MacInfo.Grade;

            //condition for each test whether it is present or not


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
            objTestList.TestList.Add(objTestCMOS);


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
            objTestList.TestList.Add(objTestSound);

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
            objTestList.TestList.Add(objTestUSB);

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
            objTestList.TestList.Add(objTestLanPort);

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
            objTestList.TestList.Add(objTestOptical);

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
            objTestList.TestList.Add(objTestLCD);

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
            objTestList.TestList.Add(objTestKeyboard);

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
            objTestList.TestList.Add(objTestTouchpad);

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
            objTestList.TestList.Add(objTestWifi);

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
            objTestList.TestList.Add(objTestBattery);

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
            objTestList.TestList.Add(objTestCamera);

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
            objTestList.TestList.Add(objTestTouchScreen);


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
            objTestList.TestList.Add(objTestMicrophone);

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
            objTestList.TestList.Add(objTestSDCard);

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
            objTestList.TestList.Add(objTestBiometric);

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
            objTestList.TestList.Add(objTestSmartCard);

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
            objTestList.TestList.Add(objTestDisplay);

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
                string strResult = getTestView(obj.testName);
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
                    if (item.TestName == obj.testName)
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

        public JsonResult GetValidation()
        {
            return Json(new
            {
                Grade = MacInfo.Grade,
                IsTestDone = MacInfo.IsTestCompleted,
                isSuccess = 1
            });

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
