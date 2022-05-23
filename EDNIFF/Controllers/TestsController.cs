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
            objTestCMOS.Id = "chkCMOS";
            objTestCMOS.TestName = "CMOS";
            objTestCMOS.TestLable = "CMOS";
            objTestCMOS.LableId = "lblCMOS";
            objTestCMOS.TestResultLable = "Optional";
            objTestCMOS.TestDone = false;
            objTestCMOS.TestSelected = false;
            objTestCMOS.TestIndex = 0;
            objTestList.TestList.Add(objTestCMOS);


            //Sound
            TestList objTestSound = new TestList();
            objTestSound.Id = "chkSound";
            objTestSound.TestName = "Sound";
            objTestSound.TestLable = "Sound";
            objTestSound.LableId = "lblSound";
            objTestSound.TestResultLable = "Optional";
            objTestSound.TestDone = false;
            objTestSound.TestSelected = false;
            objTestSound.TestIndex = 1;
            objTestList.TestList.Add(objTestSound);

            //USB
            TestList objTestUSB = new TestList();
            objTestUSB.Id = "chkUSB";
            objTestUSB.TestName = "USB";
            objTestUSB.TestLable = "USB";
            objTestUSB.LableId = "lblUSB";
            objTestUSB.TestResultLable = "Optional";
            objTestUSB.TestDone = false;
            objTestUSB.TestSelected = false;
            objTestUSB.TestIndex = 2;
            objTestList.TestList.Add(objTestUSB);

            //LanPort
            TestList objTestLanPort = new TestList();
            objTestLanPort.Id = "chkLanPort";
            objTestLanPort.TestName = "LanPort";
            objTestLanPort.TestLable = "Lan Port";
            objTestLanPort.LableId = "lblLanPort";
            objTestLanPort.TestResultLable = "Optional";
            objTestLanPort.TestDone = false;
            objTestLanPort.TestSelected = false;
            objTestLanPort.TestIndex = 3;
            objTestList.TestList.Add(objTestLanPort);

            //Optical
            TestList objTestOptical = new TestList();
            objTestOptical.Id = "chkOptical";
            objTestOptical.TestName = "Optical";
            objTestOptical.TestLable = "Optical";
            objTestOptical.LableId = "lblOptical";
            objTestOptical.TestResultLable = "Optional";
            objTestOptical.TestDone = false;
            objTestOptical.TestSelected = false;
            objTestOptical.TestIndex = 4;
            objTestList.TestList.Add(objTestOptical);

            //LCD
            TestList objTestLCD = new TestList();
            objTestLCD.Id = "chkLCD";
            objTestLCD.TestName = "LCD";
            objTestLCD.TestLable = "LCD";
            objTestLCD.LableId = "lblLCD";
            objTestLCD.TestResultLable = "Optional";
            objTestLCD.TestDone = false;
            objTestLCD.TestSelected = false;
            objTestLCD.TestIndex = 5;
            objTestList.TestList.Add(objTestLCD);

            //Keyboard
            TestList objTestKeyboard = new TestList();
            objTestKeyboard.Id = "chkKeyboard";
            objTestKeyboard.TestName = "Keyboard";
            objTestKeyboard.TestLable = "Keyboard";
            objTestKeyboard.LableId = "lblKeyboard";
            objTestKeyboard.TestResultLable = "Optional";
            objTestKeyboard.TestDone = false;
            objTestKeyboard.TestSelected = false;
            objTestKeyboard.TestIndex = 6;
            objTestList.TestList.Add(objTestKeyboard);

            //Touchpad
            TestList objTestTouchpad = new TestList();
            objTestTouchpad.Id = "chkTouchpad";
            objTestTouchpad.TestName = "Touchpad";
            objTestTouchpad.TestLable = "Touchpad";
            objTestTouchpad.LableId = "lblTouchpad";
            objTestTouchpad.TestResultLable = "Optional";
            objTestTouchpad.TestDone = false;
            objTestTouchpad.TestSelected = false;
            objTestTouchpad.TestIndex = 7;
            objTestList.TestList.Add(objTestTouchpad);

            //Wifi
            TestList objTestWifi = new TestList();
            objTestWifi.Id = "chkWifi";
            objTestWifi.TestName = "Wifi";
            objTestWifi.TestLable = "Wifi / Blue";
            objTestWifi.LableId = "lblWifi";
            objTestWifi.TestResultLable = "Optional";
            objTestWifi.TestDone = false;
            objTestWifi.TestSelected = false;
            objTestWifi.TestIndex = 8;
            objTestList.TestList.Add(objTestWifi);

            //Battery
            TestList objTestBattery = new TestList();
            objTestBattery.Id = "chkBattery";
            objTestBattery.TestName = "Battery";
            objTestBattery.TestLable = "Battery";
            objTestBattery.LableId = "lblBattery";
            objTestBattery.TestResultLable = "Optional";
            objTestBattery.TestDone = false;
            objTestBattery.TestSelected = false;
            objTestBattery.TestIndex = 9;
            objTestList.TestList.Add(objTestBattery);

            //Camera
            TestList objTestCamera = new TestList();
            objTestCamera.Id = "chkCamera";
            objTestCamera.TestName = "Camera";
            objTestCamera.TestLable = "Camera";
            objTestCamera.LableId = "lblCamera";
            objTestCamera.TestResultLable = "Optional";
            objTestCamera.TestDone = false;
            objTestCamera.TestSelected = false;
            objTestCamera.TestIndex = 10;
            objTestList.TestList.Add(objTestCamera);

            //TouchScreen
            TestList objTestTouchScreen = new TestList();
            objTestTouchScreen.Id = "chkTouchScreen";
            objTestTouchScreen.TestName = "TouchScreen";
            objTestTouchScreen.TestLable = "TouchScreen";
            objTestTouchScreen.LableId = "lblTouchScreen";
            objTestTouchScreen.TestResultLable = "Optional";
            objTestTouchScreen.TestDone = false;
            objTestTouchScreen.TestSelected = false;
            objTestTouchScreen.TestIndex = 11;
            objTestList.TestList.Add(objTestTouchScreen);


            //Microphone
            TestList objTestMicrophone = new TestList();
            objTestMicrophone.Id = "chkMicrophone";
            objTestMicrophone.TestName = "Microphone";
            objTestMicrophone.TestLable = "Microphone";
            objTestMicrophone.LableId = "lblMicrophone";
            objTestMicrophone.TestResultLable = "Optional";
            objTestMicrophone.TestDone = false;
            objTestMicrophone.TestSelected = false;
            objTestMicrophone.TestIndex = 12;
            objTestList.TestList.Add(objTestMicrophone);

            //SDCard
            TestList objTestSDCard = new TestList();
            objTestSDCard.Id = "chkSDCard";
            objTestSDCard.TestName = "SDCard";
            objTestSDCard.TestLable = "SD Card Test";
            objTestSDCard.LableId = "lblSDCard";
            objTestSDCard.TestResultLable = "Optional";
            objTestSDCard.TestDone = false;
            objTestSDCard.TestSelected = false;
            objTestSDCard.TestIndex = 13;
            objTestList.TestList.Add(objTestSDCard);

            //Biometric
            TestList objTestBiometric = new TestList();
            objTestBiometric.Id = "chkBiometric";
            objTestBiometric.TestName = "Biometric";
            objTestBiometric.TestLable = "Biometric";
            objTestBiometric.LableId = "lblBiometric";
            objTestBiometric.TestResultLable = "Optional";
            objTestBiometric.TestDone = false;
            objTestBiometric.TestSelected = false;
            objTestBiometric.TestIndex = 14;
            objTestList.TestList.Add(objTestBiometric);

            //SmartCard
            TestList objTestSmartCard = new TestList();
            objTestSmartCard.Id = "chkSmartCard";
            objTestSmartCard.TestName = "SmartCard";
            objTestSmartCard.TestLable = "Smart Card";
            objTestSmartCard.LableId = "lblSmartCard";
            objTestSmartCard.TestResultLable = "Optional";
            objTestSmartCard.TestDone = false;
            objTestSmartCard.TestSelected = false;
            objTestSmartCard.TestIndex = 15;
            objTestList.TestList.Add(objTestSmartCard);

            //Display
            TestList objTestDisplay = new TestList();
            objTestDisplay.Id = "chkDisplay";
            objTestDisplay.TestName = "Display";
            objTestDisplay.TestLable = "Display";
            objTestDisplay.LableId = "lblDisplay";
            objTestDisplay.TestResultLable = "Optional";
            objTestDisplay.TestDone = false;
            objTestDisplay.TestSelected = false;
            objTestDisplay.TestIndex = 16;
            objTestList.TestList.Add(objTestDisplay);

            //PortTest
            TestList objTestPortTest = new TestList();
            objTestPortTest.Id = "chkPortTest";
            objTestPortTest.TestName = "PortTest";
            objTestPortTest.TestLable = "Port Test";
            objTestPortTest.LableId = "lblPortTest";
            objTestPortTest.TestResultLable = "Optional";
            objTestPortTest.TestDone = false;
            objTestPortTest.TestSelected = false;
            objTestPortTest.TestIndex = 17;
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
                    string strDeviceUSB = TestName + "_Port";
                    Device objDeviceUSB = MacInfo.devices.Where(x => x.TestName == strDeviceUSB).FirstOrDefault();
                    strResult = GetSoundUSB(objDeviceUSB);
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
                            "<th colspan='4'>CMOS Test" +
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
                                "<input type='text' class='form-control' id='txtCMOSComment' placeholder=''>" +
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
                            "<th colspan='4'>Sound Test" +
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


                        "<tr>" +
                        "<td class='td50 Allignleft'> Comments </td>" +
                        "<td class='td50 Allignleft'>" +
                            "<div class='form-check paddingleft'>" +
                                "<input type='text' class='form-control' id='txtCMOSComment' placeholder=''>" +
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

        public string GetSoundUSB(Device objDevice)
        {
            string strResult = string.Empty;
            if (objDevice != null)
            {

                strResult = "<table class='table'>" +
                        "<thead class='thead-dark'><tr> " +
                            "<th colspan='4'>USB Test" +
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


                        "<tr>" +
                        "<td class='td50 Allignleft'> Comments </td>" +
                        "<td class='td50 Allignleft'>" +
                            "<div class='form-check paddingleft'>" +
                                "<input type='text' class='form-control' id='txtCMOSComment' placeholder=''>" +
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
