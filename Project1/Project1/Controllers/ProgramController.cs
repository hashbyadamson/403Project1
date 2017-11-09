using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class ProgramController : Controller
    {
        // GET: Program
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProgramView(string proName, string internName, string sfccAddress, string ageGroup, string weekdayTime, string proDesc)
        {
            ViewBag.ProgramName = proName;
            ViewBag.InternName = internName;
            ViewBag.SFCCAddress = sfccAddress;
            ViewBag.AgeGroup = ageGroup;
            ViewBag.WeekdayTime = weekdayTime;
            ViewBag.ProgDescription = proDesc;


            return View();
        }
    }
}