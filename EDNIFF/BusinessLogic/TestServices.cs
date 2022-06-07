﻿using EDNIFF.APIModels;
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
        public async Task<int> SaveMethod(MainSaveMethodParam obj)
        {
            try
            {
                CommonMethods objCommonMethods = new CommonMethods();

                Device objProcessor = objCommonMethods.GetDevice(ConstantData.Categories.Processor, ConstantData.DeviceNames.Processor);

                Device objMotherBoard = objCommonMethods.GetDevice(ConstantData.Categories.MotherBoard, ConstantData.DeviceNames.MotherBoard);
                Device objOptical = objCommonMethods.GetDevice(ConstantData.Categories.Other, ConstantData.DeviceNames.CDROMDrive);

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


                objParam.Optical = obj._listOfTest.Where(x => x.TestName == "Optical").Select(x => x.TestResult).FirstOrDefault();

                objParam.SpeakerTest = obj._listOfTest.Where(x => x.TestName == "Sound").Select(x => x.TestResult).FirstOrDefault();
                objParam.Webcam = obj._listOfTest.Where(x => x.TestName == "Camera").Select(x => x.TestResult).FirstOrDefault();
                objParam.LAN = obj._listOfTest.Where(x => x.TestName == "LanPort").Select(x => x.TestResult).FirstOrDefault();
                objParam.Wifi = obj._listOfTest.Where(x => x.TestName == "Wifi").Select(x => x.TestResult).FirstOrDefault();
                objParam.Keyboard = obj._listOfTest.Where(x => x.TestName == "Keyboard").Select(x => x.TestResult).FirstOrDefault();
                objParam.MACADD = MacInfo.MACAddress;
                objParam.Touchpad = obj._listOfTest.Where(x => x.TestName == "Touchpad").Select(x => x.TestResult).FirstOrDefault();
                




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
