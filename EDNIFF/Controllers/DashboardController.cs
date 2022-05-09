using EDNIFF.APIModels;
using EDNIFF.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

            //get dahboard details
            systeminfo = new SystemInfo();
            systeminfo.LoadDevices();

            return View();
        }
    }
}
