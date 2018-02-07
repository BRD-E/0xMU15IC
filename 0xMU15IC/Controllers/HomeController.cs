using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using _0xMU15IC.Models;
using _0xMU15IC.Controllers;
using System.Linq;
using System.Web;


namespace _0xMU15IC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFiles()
        {

            return Json("file uploaded successfully");
        }
    }
}