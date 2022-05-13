using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Controllers
{
    public class ObservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
