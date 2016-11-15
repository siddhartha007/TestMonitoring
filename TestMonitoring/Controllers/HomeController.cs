using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMonitoring.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            System.Diagnostics.Trace.TraceError("If you're seeing this, something bad happened");
            Trace.TraceInformation("My trace statement");
            Trace.TraceWarning("My warning statement");
            Trace.TraceError("My error statement");
            //console.log("My trace statement");


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}