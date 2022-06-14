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
                //MainSaveMethodParam obj = new MainSaveMethodParam();

                //obj._listOfTest = MacInfo.TestList;

                if (string.IsNullOrEmpty(MacInfo.Grade))
                {
                    return 101;
                }
                if (MacInfo.IsTestCompleted == false)
                {
                    return 102;
                }

                CommonMethods objCommonMethods = new CommonMethods();

                Device objProcessor = objCommonMethods.GetDevice(ConstantData.Categories.Processor, ConstantData.DeviceNames.Processor);
                Device objMotherBoard = objCommonMethods.GetDevice(ConstantData.Categories.MotherBoard, ConstantData.DeviceNames.MotherBoard);
                Device objOptical = objCommonMethods.GetDevice(ConstantData.Categories.Other, ConstantData.DeviceNames.CDROMDrive);
                Device objBattery = objCommonMethods.GetDevice(ConstantData.Categories.Battery, ConstantData.DeviceNames.Battery);
                Device objDisplay = objCommonMethods.GetDevice(ConstantData.Categories.Display, ConstantData.DeviceNames.Video);

                vwSystemInfoDetail objParam = new vwSystemInfoDetail();
                var dict = new Dictionary<string, object>();

                objParam.UnitId = 212297;
                dict.Add("UnitId", objParam.UnitId);

                objParam.SerialNumber = MacInfo.devices.Where(x => x.Category == ConstantData.Categories.Processor && x.DeviceName == ConstantData.DeviceNames.Processor).Select(x => x.Serial).FirstOrDefault();
                dict.Add("SerialNumber", objParam.SerialNumber);

                objParam.InhouseSerialNo = "101601527962";
                dict.Add("InhouseSerialNo", objParam.InhouseSerialNo);

                objParam.COA = MacInfo.OSCOA;
                dict.Add("COA", objParam.COA);

                objParam.Resolution = MacInfo.Resolution;
                dict.Add("Resolution", objParam.Resolution);

                objParam.PartNumber = "";
                dict.Add("PartNumber", objParam.PartNumber);

                objParam.Manufacturer = "Apple";
                dict.Add("Manufacturer", objParam.Manufacturer);

                objParam.Model = objMotherBoard.Info1;
                dict.Add("Model", objParam.Model);

                objParam.Processor = objProcessor.Model;
                dict.Add("Processor", objParam.Processor);

                objParam.ProcSpeed = objProcessor.Speed;
                dict.Add("ProcSpeed", objParam.ProcSpeed);

                objParam.RAM = objProcessor.Size;
                dict.Add("RAM", objParam.RAM);

                objParam.StorageSize = MacInfo.StorageSize;
                dict.Add("StorageSize", objParam.StorageSize);

                objParam.StorageType = MacInfo.StorageType;
                dict.Add("StorageType", objParam.StorageType);

                objParam.Optical = MacInfo.TestList.Where(x => x.testName == "Optical").Select(x => x.testResult).FirstOrDefault();
                dict.Add("Optical", objParam.Optical);

                objParam.SpeakerTest = MacInfo.TestList.Where(x => x.testName == "Sound").Select(x => x.testResult).FirstOrDefault(); 
                dict.Add("SpeakerTest", objParam.SpeakerTest);

                objParam.Webcam = MacInfo.TestList.Where(x => x.testName == "Camera").Select(x => x.testResult).FirstOrDefault();
                dict.Add("Webcam", objParam.Webcam);

                objParam.LAN = MacInfo.TestList.Where(x => x.testName == "LanPort").Select(x => x.testResult).FirstOrDefault();
                dict.Add("LAN", objParam.LAN);

                objParam.Wifi = MacInfo.TestList.Where(x => x.testName == "Wifi").Select(x => x.testResult).FirstOrDefault();
                dict.Add("Wifi", objParam.Wifi);

                objParam.Keyboard = MacInfo.TestList.Where(x => x.testName == "Keyboard").Select(x => x.testResult).FirstOrDefault();
                dict.Add("Keyboard", objParam.Keyboard);

                objParam.MACADD = MacInfo.MACAddress;
                dict.Add("MACADD", objParam.MACADD);

                objParam.Touchpad = MacInfo.TestList.Where(x => x.testName == "Touchpad").Select(x => x.testResult).FirstOrDefault();
                dict.Add("Touchpad", objParam.Touchpad);

                objParam.BatteryTest = MacInfo.TestList.Where(x => x.testName == "Battery").Select(x => x.testResult).FirstOrDefault();
                dict.Add("BatteryTest", objParam.BatteryTest);

                objParam.BatteryHealth = objBattery.Info1;
                dict.Add("BatteryHealth", objParam.BatteryHealth);

                objParam.VideoCard = objDisplay.Model;
                dict.Add("VideoCard", objParam.VideoCard);

                objParam.GRADE = MacInfo.Grade;
                dict.Add("GRADE", objParam.GRADE);

                objParam.BoardTest = MacInfo.TestList.Where(x => x.testName == "CMOS").Select(x => x.testResult).FirstOrDefault();
                dict.Add("BoardTest", objParam.BoardTest);

                if (MacInfo.devices != null && MacInfo.devices.Count() > 0)
                {
                    var devices = MacInfo.devices.Where(x => x.DevicePresent).Select(x => new
                    {
                        Category = x.Category.ToString(),
                        DeviceName = x.DeviceName.ToString(),
                        x.Manufacturer,
                        x.Model,
                        x.Serial,
                        x.Size,
                        x.Speed,
                        x.Info1,
                        x.Info2,
                        x.Caption,
                        x.Description,
                        x.Status,
                        x.boolInfo1,
                        x.boolInfo2,
                        x.Comment,
                        DeviceStatus = x.deviceStatus.ToString()
                    }).ToList();
                    dict.Add("devices", devices);
                }

                

                HttpAPIRequests httpRequest = new HttpAPIRequests();
                var response = await httpRequest.PostRequest<long>("Macos/MainSaveMethod", dict);
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
