using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;
using static EDNIFF.Models.DeviceProps;

namespace EDNIFF.BusinessLogic
{
    abstract class BaseHardwareInfo
    {
        public string GetInfoString(string InfoVariable)
        {
            string strReturn = string.Empty;

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
                cmd.Arguments = "-c \"system_profiler " + InfoVariable + " \"";
            }
            else
            {
                return "";
            }

            var builder = new StringBuilder();
            using (Process process = Process.Start(cmd))
            {
                process.WaitForExit();
                builder.Append(process.StandardOutput.ReadToEnd());
            }
            if (builder.ToString().Trim() != string.Empty)
            {
                strReturn = builder.ToString().Trim();
            }
            
            return strReturn;
        }

        public string GetPropertyValue(string items)
        {
            string[] strValueArr = items.Split(':');
            string strValue = strValueArr[1].Trim();
            return strValue;
        }       

    }
}
