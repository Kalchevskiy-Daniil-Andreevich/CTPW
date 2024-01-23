using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPCMVC04.Controllers
{
    public class StatusController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("Status/S200")]
        public ActionResult S200()
        {
            return StatusCode(250);
        }
        [Route("Status/S300")]
        public ActionResult S300()
        {
            return StatusCode(340);
        }
        [Route("Status/S500")]
        public ActionResult S500()
        {
            return StatusCode(520);
        }
    }
}