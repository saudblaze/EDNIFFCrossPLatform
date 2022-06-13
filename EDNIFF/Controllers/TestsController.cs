using EDNIFF.BusinessLogic;
using EDNIFF.Common;
using EDNIFF.Models;
using EDNIFF.ViewModel;
using Microsoft.AspNetCore.Mvc;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
            objTestList.TestList = MacInfo.TestList;
            objTestList.Grade = MacInfo.Grade;
            objTestList.IsTestCompleted = MacInfo.IsTestCompleted;
            //condition for each test whether it is present or not

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

                foreach (TestList item in MacInfo.TestList)
                {
                    if (item.testName == obj.testName)
                    {
                        item.testDone = true;
                        item.className = obj.className;
                        item.testResult = obj.testResult;
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

        public JsonResult SetTestDone(TestVM obj)
        {

            if (obj != null)
            {
                MacInfo.IsTestCompleted = obj.IsTestCompleted;
                //MacInfo.TestList = obj.TestList;

                return Json(new { IsSuccess = 1 });
            }
            else
            {
                return Json(new { IsSuccess = 0 });
            }
        }

        public JsonResult SetIsSelectedTestList(List<TestList> obj)
        {

            if (obj != null)
            {

                MacInfo.TestList = new List<TestList>();
                MacInfo.TestList = obj;
                return Json(new { IsSuccess = 1 });
            }
            else
            {
                return Json(new { IsSuccess = 0 });
            }
        }

        
        public async Task<JsonResult> MainSaveMethod()
        {
            var objResult = await objTestServices.SaveMethod();
            return Json(new { isSuccess = objResult });
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
                                "<input class='form-check-input' type='radio' id='rd"+ objDevice.TestName + "Pass' name='CMOS' onchange='MarkAsCompleted(\"Pass\")' value='Pass' >" +
                                "<label class='form-check-label'>Pass</label>" +
                            "</div>" +
                            "<div class='form-check form-check-inline'>" +
                                "<input class='form-check-input' type='radio' id='rd"+ objDevice.TestName + "Fail' name='CMOS' onchange='MarkAsCompleted(\"Fail\")' value='Fail' >" +
                                "<label class='form-check-label'>Fail</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Result </td>" +
                        "<td>" +
                            "<div>" +
                                "<label class='form-check-label' id='lblResult" + objDevice.TestName + "'>Not Tested</label>" +
                            "</div>" +
                        "</td>" +
                        "</tr>" +

                        "<tr>" +
                        "<td> Comments </td>" +
                        "<td>" +
                            "<div >" +
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

        public void PlayLeftSpeaker()
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"~/Files/leftSpeaker.wav");
            player.Play();

            //SoundPlayer player = new SoundPlayer();
            //MMDevice defaultDevice;
            //MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            //defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            //defaultDevice.AudioEndpointVolume.Mute = false;
            
            //defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = 1F;
            //defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = 0F;
            //player.SoundLocation = "Files/leftSpeaker.wav";
            ////changeColor(pictureBox1, 50);
            ////changeColor(pictureBox2, 0);
            //player.LoadAsync();
            //player.PlaySync();
            ////this is required bcoz there is a delay on switching channel volume
            //defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = 1F;
            //defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = 1F;
            

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
