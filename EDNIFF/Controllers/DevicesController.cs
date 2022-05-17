using EDNIFF.Common;
using EDNIFF.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Controllers
{
    public class DevicesController : Controller
    {
        public IActionResult Index()
        {
            MacinfoVM objMacinfoVM = new MacinfoVM();
            objMacinfoVM = MacInfo.MapMacInfoVM();


            return View(objMacinfoVM);
        }
    }
}
