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


                //PublicVariables.WebApiURL = "https://localhost:44346/api";//Properties.Settings.Default.APIUrls[apiindex];
                HttpAPIRequests httpRequest = new HttpAPIRequests();
                var response = await httpRequest.PostRequestForLogin<AuthDetails>(obj.Username.Trim(), obj.Password);
                if (response.hasError)
                {
                    //alert("123");
                    return View("Index.cshtml");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View("Index.cshtml");
            }

            
        }
    }
}
