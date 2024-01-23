using Microsoft.AspNetCore.Mvc;

namespace ASPCMVC08.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Calc");
        }

        [HttpPost("/Sum")]
        [Route("/Sum")]
        public ActionResult Sum(float firstNumber, float secondNumber)
        {
            float sumNumber = firstNumber + secondNumber;
            ViewBag.Result = sumNumber;
            ViewBag.press = "+";
            return View("Calc");
        }

		[HttpPost("/Sub")]
		[Route("/Sub")]
		public ActionResult Sub(float firstNumber, float secondNumber)
        {
            float subNumber = firstNumber - secondNumber;
            ViewBag.Result = subNumber;
            ViewBag.press = "-";
            return View("Calc");
        }

		[HttpPost("/Mul")]
		[Route("/Mul")]
        public ActionResult Mul(float firstNumber, float secondNumber)
        {
            float mulNumber = firstNumber * secondNumber;
            ViewBag.Result = mulNumber;
            ViewBag.press = "*";
            return View("Calc");
        }

        [HttpPost("/Div")]
        [Route("/Div")]
        public IActionResult Div(float firstNumber, float secondNumber)
        {
            if (secondNumber != 0)
            {
                float divNumber = firstNumber / secondNumber;
                ViewBag.Result = divNumber;
            }
            else
                ViewBag.Error = "-- ERROR --";

            ViewBag.press = "/";
            return View("Calc");
        }
    }
}