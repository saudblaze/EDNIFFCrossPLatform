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
        SPHardwareDataType _SPHardwareDataType;

        public DashboardController()
        {
            _SPHardwareDataType = new SPHardwareDataType();
        }

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
            

            return View(systeminfo.MacInfo);
        }

        public void GetSPHardwareDataType()
        {
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
                else {
                    return;
                }

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
                    if (items.ToString().Contains("Provisioning UDID"))
                    {
                        string[] strValueArr = items.Split(':');
                        string strValue = strValueArr[1].Trim();
                        sPHardwareDataType.ProvisioningUDID = strValue;
                    }
                }

            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
