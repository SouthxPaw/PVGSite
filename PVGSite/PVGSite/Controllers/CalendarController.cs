using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PVGSite.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult Calendar()
        {
            return View();
        }
    }
}