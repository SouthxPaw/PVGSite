using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PVGSite.Models;
using System.Data.SqlClient;

namespace PVGSite.Controllers
{
    public class AccountController : Controller
    {   

        //GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        void connectionString()
        {

        }
        public ActionResult Verify(AccountViewModel account)
        {
            return View();
        }
    }
}