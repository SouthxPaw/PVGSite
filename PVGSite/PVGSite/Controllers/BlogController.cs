using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PVGSite.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Blog()
        {
            return View();
        }
    }
}