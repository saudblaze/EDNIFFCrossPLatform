using EDNIFF.Common;
using EDNIFF.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Text;

namespace EDNIFF.Controllers
{
    public class DashboardController : Controller
    {
        SystemInfo systeminfo;
        public IActionResult Index()
        {
            string access_token = Global.access_token;
            string token_type = Global.token_type;
            int expires_in = Global.expires_in;

            string displayName = Global.displayName;
            string userName = Global.userName;
            string userid = Global.userid;

            DateTime? lastLogin = Global.lastLogin;
            DateTime? expires = Global.expires;

            String hostName = Dns.GetHostName();

            String MachineName = Environment.MachineName;


            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //process.StartInfo.FileName = "cmd.exe";
            //System.Diagnostics.Process.Start(@"/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal", @"~/Users/apple/Documents/myscript.sh");
            //process.StartInfo.Arguments = "system_profiler SPHardwareDataType";
            //process.Start();

            StringBuilder systemInfo = new StringBuilder(string.Empty);

            systemInfo.AppendFormat("Operation System:  {0}n", Environment.OSVersion);
            systemInfo.AppendFormat("Processor Architecture:  {0}n", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            systemInfo.AppendFormat("Processor Model:  {0}n", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            systemInfo.AppendFormat("Processor Level:  {0}n", Environment.GetEnvironmentVariable("PROCESSOR_LEVEL"));
            systemInfo.AppendFormat("SystemDirectory:  {0}n", Environment.SystemDirectory);
            systemInfo.AppendFormat("ProcessorCount:  {0}n", Environment.ProcessorCount);
            systemInfo.AppendFormat("UserDomainName:  {0}n", Environment.UserDomainName);
            systemInfo.AppendFormat("UserName: {0}n", Environment.UserName);
            //Drives
            systemInfo.AppendFormat("LogicalDrives:n");
            foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
            {
                try
                {
                    systemInfo.AppendFormat("t Drive: {0}ntt VolumeLabel: " +
                        "{1}ntt DriveType: {2}ntt DriveFormat: {3}ntt " +
                        "TotalSize: {4}ntt AvailableFreeSpace: {5}n",
                        DriveInfo1.Name, DriveInfo1.VolumeLabel, DriveInfo1.DriveType,
                        DriveInfo1.DriveFormat, DriveInfo1.TotalSize, DriveInfo1.AvailableFreeSpace);
                }
                catch
                {
                }
            }
            systemInfo.AppendFormat("Version:  {0}", Environment.Version);
            Console.WriteLine(systemInfo);

            try
            {


                var cmd = new ProcessStartInfo();
                cmd.RedirectStandardError = true;
                cmd.CreateNoWindow = true;
                cmd.UseShellExecute = false;
                cmd.RedirectStandardOutput = true;

                if (System.OperatingSystem.IsWindows())
                {
                    cmd.FileName = "CMD.exe";
                    cmd.Arguments = "/C wmic csproduct get name | find /v \"Name\"";
                }
                else if (System.OperatingSystem.IsMacOS())
                {
                    cmd.FileName = "sh";
                    cmd.Arguments = "-c \"system_profiler SPHardwareDataType\"";
                }
                else return null;

                try
                {

                    var builder = new StringBuilder();
                    using (Process process = Process.Start(cmd))
                    {
                        process.WaitForExit();
                        builder.Append(process.StandardOutput.ReadToEnd());
                    }

                    string strtemp = builder.ToString().Trim();
                    string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    SPHardwareDataType sPHardwareDataType = new SPHardwareDataType();
                    foreach (string items in linesArr)
                    {

                        if (items.ToString().Contains("Model Name"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.ModelName = strValue;
                        }
                        if (items.ToString().Contains("Model Identifier"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.ModelIdentifier = strValue;
                        }
                        if (items.ToString().Contains("Processor Name"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.ProcessorName = strValue;
                        }
                        if (items.ToString().Contains("Processor Speed"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.ProcessorSpeed = strValue;
                        }
                        if (items.ToString().Contains("Number of Processors"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.NumberOfProcessors = strValue;
                        }
                        if (items.ToString().Contains("Total Number of Cores"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.TotalNumberOfCores = strValue;
                        }
                        if (items.ToString().Contains("L2 Cache"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.L2Cache = strValue;
                        }
                        if (items.ToString().Contains("L3 Cache"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.L3Cache = strValue;
                        }
                        if (items.ToString().Contains("Hyper-Threading Technology"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.HyperThreadingTechnology = strValue;
                        }
                        if (items.ToString().Contains("Memory"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.Memory = strValue;
                        }
                        if (items.ToString().Contains("System Firmware Version"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.SystemFirmwareVersion = strValue;
                        }
                        if (items.ToString().Contains("SMC Version"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.SMCVersion = strValue;
                        }
                        if (items.ToString().Contains("Serial Number"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.SerialNumber = strValue;
                        }
                        if (items.ToString().Contains("Hardware UUID"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.HardwareUUID = strValue;
                        }
                        if (items.ToString().Contains("ProvisioningUDID"))
                        {
                            string[] strValueArr = items.Split(':');
                            string strValue = strValueArr[1].Trim();
                            sPHardwareDataType.ProvisioningUDID = strValue;
                        }
                    }

                }
                catch (Exception)
                {
                    return null;
                }






                //var appContentResources = Environment.CurrentDirectory;
                //var command = appContentResources + "/myscript.sh";

                ////var command = @"~/Users/apple/Documents/myscript.sh";
                //var scriptFile = @"~/Users/apple/Documents/myscript.sh";//Path to shell script file
                //var arguments = string.Format("{0} {1} {2} {3} {4}", "testarg1", "testarg2", "testarg3", "testarg3", "testarg4");
                //var process = new Process { StartInfo = { FileName = command } };


                //var processReult = process.Start();   // Start that process.
                ////while (!process.StandardOutput.EndOfStream)
                ////{
                ////    string result = process.StandardOutput.ReadLine();
                ////    // do something here
                ////}
                ////process.WaitForExit();
                //if (processReult)
                //{ 

                //}
                //else
                //{ 

                //}
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }





            //string Mac = string.Empty;
            //ManagementClass MC = new ManagementClass("system_profiler SPHardwareDataType");
            //ManagementObjectCollection MOCol = MC.GetInstances();
            //foreach (ManagementObject MO in MOCol)
            //    if (MO != null)
            //    {
            //        if (MO["MacAddress"] != null)
            //        {
            //            Mac = MO["MACAddress"].ToString();
            //            if (Mac != string.Empty)
            //                break;
            //        }
            //    }
            //return Mac;

            //get dahboard details
            //systeminfo = new SystemInfo();
            //systeminfo.LoadDevices();

            return View();
        }
    }
}
