using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPCMVC06.Controllers
{
    public class TMResearchController : Controller
    {
        public IActionResult GETM01(string str)
        {
            ViewBag.str = str;
            return View();
        }
        public IActionResult GETM02(string str)
        {
            ViewBag.str = str;
            return View();
        }
        public IActionResult GETM03(string str)
        {
            ViewBag.str = str;
            return View();
        }

        public IActionResult MXX()
        {
            return View();
        }
    }
}