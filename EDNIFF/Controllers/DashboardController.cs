﻿using EDNIFF.APIModels;
using EDNIFF.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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


            string Mac = string.Empty;
            ManagementClass MC = new ManagementClass("Win32_NetworkAdapter");
            ManagementObjectCollection MOCol = MC.GetInstances();
            foreach (ManagementObject MO in MOCol)
                if (MO != null)
                {
                    if (MO["MacAddress"] != null)
                    {
                        Mac = MO["MACAddress"].ToString();
                        if (Mac != string.Empty)
                            break;
                    }
                }
            //return Mac;

            //get dahboard details
            //systeminfo = new SystemInfo();
            //systeminfo.LoadDevices();

            return View();
        }
    }
}