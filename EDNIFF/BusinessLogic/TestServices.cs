using EDNIFF.APIModels;
using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using EDNIFF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EDNIFF.BusinessLogic
{
    public class TestServices
    {
        public async Task<int> SaveMethod()
        {
            try
            {
                MainSaveMethodParam obj = new MainSaveMethodParam();

                obj._listOfTest = MacInfo.TestList;
                

                CommonMethods objCommonMethods = new CommonMethods();

                Device objProcessor = objCommonMethods.GetDevice(ConstantData.Categories.Processor, ConstantData.DeviceNames.Processor);
                Device objMotherBoard = objCommonMethods.GetDevice(ConstantData.Categories.MotherBoard, ConstantData.DeviceNames.MotherBoard);
                Device objOptical = objCommonMethods.GetDevice(ConstantData.Categories.Other, ConstantData.DeviceNames.CDROMDrive);
                Device objBattery = objCommonMethods.GetDevice(ConstantData.Categories.Battery, ConstantData.DeviceNames.Battery);
                Device objDisplay = objCommonMethods.GetDevice(ConstantData.Categories.Display, ConstantData.DeviceNames.Video);

                vwSystemInfoDetail objParam = new vwSystemInfoDetail();

                objParam.UnitId = 212297;
                objParam.SerialNumber = MacInfo.devices.Where(x => x.Category == ConstantData.Categories.Processor && x.DeviceName == ConstantData.DeviceNames.Processor).Select(x => x.Serial).FirstOrDefault(); 
                objParam.InhouseSerialNo = "101601527962";
                objParam.COA = MacInfo.OSCOA;
                objParam.Resolution = MacInfo.Resolution;
                objParam.PartNumber = "";
                objParam.Manufacturer = "Apple";
                objParam.Model = objMotherBoard.Info1;
                objParam.Processor = objProcessor.Model;
                objParam.ProcSpeed = objProcessor.Speed;
                objParam.RAM = objProcessor.Size;
                objParam.StorageSize = MacInfo.StorageSize;
                objParam.StorageType = MacInfo.StorageType;


                objParam.Optical = MacInfo.TestList.Where(x => x.testName == "Optical").Select(x => x.testResult).FirstOrDefault();

                objParam.SpeakerTest = MacInfo.TestList.Where(x => x.testName == "Sound").Select(x => x.testResult).FirstOrDefault();
                objParam.Webcam = MacInfo.TestList.Where(x => x.testName == "Camera").Select(x => x.testResult).FirstOrDefault();
                objParam.LAN = MacInfo.TestList.Where(x => x.testName == "LanPort").Select(x => x.testResult).FirstOrDefault();
                objParam.Wifi = MacInfo.TestList.Where(x => x.testName == "Wifi").Select(x => x.testResult).FirstOrDefault();
                objParam.Keyboard = MacInfo.TestList.Where(x => x.testName == "Keyboard").Select(x => x.testResult).FirstOrDefault();
                objParam.MACADD = MacInfo.MACAddress;
                objParam.Touchpad = MacInfo.TestList.Where(x => x.testName == "Touchpad").Select(x => x.testResult).FirstOrDefault();
                objParam.BatteryTest = MacInfo.TestList.Where(x => x.testName == "Battery").Select(x => x.testResult).FirstOrDefault();
                objParam.BatteryHealth = objBattery.Info1;
                objParam.VideoCard = objDisplay.Model;
                objParam.GRADE = MacInfo.Grade;
                objParam.BoardTest = MacInfo.TestList.Where(x => x.testName == "CMOS").Select(x => x.testResult).FirstOrDefault();





                var dict = new Dictionary<string, object>();
                //foreach (ReportProps prop in Enum.GetValues(typeof(ReportProps)))
                //{
                //    //switch (prop)
                //    //{
                //    //    case ReportProps.KeyboardLng:
                //    //        dict.Add(prop.ToString(), KeyboardLanguage);
                //    //        break;
                //    //    case ReportProps.MADEIN:
                //    //        dict.Add(prop.ToString(), Madein);
                //    //        break;
                //    //    case ReportProps.COA:
                //    //        dict.Add(prop.ToString(), OSCOA);
                //    //        break;
                //    //    case ReportProps.ObservNotes:
                //    //        dict.Add(prop.ToString(), ObservationComment);
                //    //        break;
                //    //    case ReportProps.UnitId:
                //    //        dict.Add(prop.ToString(), UnitId);
                //    //        break;
                //    //    case ReportProps.Grade:
                //    //        dict.Add(prop.ToString(), Grade);
                //    //        break;
                //    //    case ReportProps.BatteryBackup:
                //    //        if (!string.IsNullOrEmpty(batterybackupresult))
                //    //            dict.Add(prop.ToString(), batterybackupresult);
                //    //        break;
                //    //    //case ReportProps.RAM:
                //    //    //    dict.Add(prop.ToString(), UtilityHelper.GetDataSize(PublicVariables.RAMSize));
                //    //    //    break;

                //    //    case ReportProps.PartNumber:
                //    //        dict.Add(prop.ToString(), PartNumber);
                //    //        break;
                //    //    case ReportProps.RAM:
                //    //        dict.Add(prop.ToString(), RamSize);
                //    //        break;
                //    //    case ReportProps.StorageType:
                //    //        dict.Add(prop.ToString(), DiskType);
                //    //        break;
                //    //    case ReportProps.StorageSize:
                //    //        dict.Add(prop.ToString(), DiskSize);
                //    //        break;

                //    //    case ReportProps.Resolution:
                //    //        dict.Add(prop.ToString(), VideoRes);
                //    //        break;
                //    //    case ReportProps.DisplaySize:
                //    //        dict.Add(prop.ToString(), LCDSize);
                //    //        break;

                //    //    //case ReportProps.StorageHealth:
                //    //    //    dict.Add(prop.ToString(), UtilityHelper.GetDataSize(PublicVariables.RAMSize));
                //    //    //    break;
                //    //    default:
                //    //        dict.Add(prop.ToString(), system.getPropertyValue(result, prop));
                //    //        break;
                //    //}

                //}

                //dict.Add("NoOfPorts", PublicVariables.noofPorts);



                HttpAPIRequests httpRequest = new HttpAPIRequests();
                var response = await httpRequest.PostRequest<long>("Macos/MainSaveMethod", objParam);
                if (response.hasError)
                {
                    //MessageBox.Show(response.message, "Error");
                    return 0;
                }
                else
                {
                    return 1;
                }                
            }
            catch (Exception ex)
            {
                return 101;
            }            
        }
    }
}
