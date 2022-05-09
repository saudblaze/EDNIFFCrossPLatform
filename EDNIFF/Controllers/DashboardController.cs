using EDNIFF.APIModels;
using EDNIFF.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Threading.Tasks;

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


            var command = @"~/Users/apple/Documents/myscript.sh";
            var scriptFile = @"~/Users/apple/Documents/myscript.sh";//Path to shell script file
            var arguments = string.Format("{0} {1} {2} {3} {4}", "testarg1", "testarg2", "testarg3", "testarg3", "testarg4");
            var processInfo = new ProcessStartInfo()
            {
                FileName = command,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true

            };

            Process process = Process.Start(processInfo);   // Start that process.
            while (!process.StandardOutput.EndOfStream)
            {
                string result = process.StandardOutput.ReadLine();
                // do something here
            }
            process.WaitForExit();

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
