using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ASPCMVC07.Controllers
{
    public class TAResearch : Controller
    {
        [HttpGet("/it/{n}/{str}")]
        [Route("/it/{n}/{str}")]
        public IActionResult GETM04(int n, string str)
        {
            ViewBag.str = str;
            ViewBag.n = n;
            return View();
        }

        [HttpGet("/it/{b}/{letters:alpha}")]
        [Route("/it/{b}/{letters:alpha}")]
        public IActionResult GETM05(bool b, string letters)
        {
            ViewBag.b = b;
            ViewBag.letters = letters;
            return View();
        }

        [HttpPost("/it/{b}/{letters:alpha}")]
        [Route("/it/{b}/{letters:alpha}")]
        public IActionResult POSTM05(bool b, string letters)
        {
            ViewBag.b = b;
            ViewBag.letters = letters;
            return View();
        }

        [HttpGet("/it/M06/{f}/{str:minlength(2):maxlength(5)}")]
        [Route("/it/M06/{f}/{str:minlength(2):maxlength(5)}")]
        public IActionResult GETM06(float f, string str)
        {
            ViewBag.Message = "GET:M06:/" + f + "/" + str;
            return View();
        }

        [HttpDelete("/it/{f}/{str:minlength(2):maxlength(5)}")]
        [Route("/it/{f}/{str:minlength(2):maxlength(5)}")]
        public IActionResult DELETEM06(float f, string str)
        {
            ViewBag.Message = "DELETE:M06:/" + f + "/" + str;
            return View();
        }

        [HttpPut("/it/{letters:alpha:minlength(3):maxlength(4)}/{n:min(100):max(200)}")]
        [Route("/it/{letters:alpha:minlength(3):maxlength(4)}/{n:min(100):max(200)}")]
        public IActionResult PUTM07(string letters, int n)
        {
            ViewBag.Message = "PUT:M07:/" + letters + "/" + n;
            return View();
        }

        [HttpPost("/it/{mail}")]
        [Route("/it/{mail}")]
        public IActionResult POSTM08([RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")] string mail)
        {
            ViewBag.Message = "POST:M08:/" + mail;
            return View();
        }

    }
}