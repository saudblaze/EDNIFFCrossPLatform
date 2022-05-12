using EDNIFF.APIModels;
using EDNIFF.Common;
using EDNIFF.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Login(EmployeeCreateVM obj)
        {
            try
            {
                if (obj.LoginURL == "1")
                {
                    PublicVariables.WebApiURL = "http://192.168.2.6:91/api";
                }
                else if (obj.LoginURL == "2")
                {
                    PublicVariables.WebApiURL = "http://192.168.2.14:91/api";
                }
                else //(obj.LoginURL == "3")
                {
                    PublicVariables.WebApiURL = "https://localhost:44346/api";
                }


                obj.Password = "Pass@123";
                obj.Username = "A2C0523";
                PublicVariables.WebApiURL = "http://192.168.2.14:91/api";

                //PublicVariables.WebApiURL = "https://localhost:44346/api";//Properties.Settings.Default.APIUrls[apiindex];
                HttpAPIRequests httpRequest = new HttpAPIRequests();
                var response = await httpRequest.PostRequestForLogin<AuthDetails>(obj.Username.Trim(), obj.Password);
                if (response.hasError)
                {
                    return View("Index.cshtml");
                }
                else
                {

                    Global.access_token = response.successData.access_token;
                    Global.token_type = response.successData.token_type;
                    Global.expires_in = response.successData.expires_in;

                    Global.displayName = response.successData.displayName;
                    Global.userName = response.successData.userName;
                    Global.userid = response.successData.userid;

                    Global.lastLogin = response.successData.lastLogin;
                    Global.expires = response.successData.expires;


                    SystemInfo systeminfo = new SystemInfo();
                    systeminfo.LoadDevices();


                    return RedirectToAction("Index", "Dashboard");

                }
            }
            catch (Exception ex)
            {
                return View("Index.cshtml");
            }


        }
    }
}
