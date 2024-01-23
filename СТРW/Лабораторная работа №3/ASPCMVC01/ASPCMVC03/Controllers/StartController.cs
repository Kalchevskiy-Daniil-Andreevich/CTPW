using Microsoft.AspNetCore.Mvc;


namespace ASPCMVC03.Controllers
{
    public class StartController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("Start/One")]
        public ActionResult One()
        {
            return View();
        }
        [Route("Start/Two")]
        public ActionResult Two()
        {
            return View();
        }
        [Route("Start/Three")]
        public ActionResult Three()
        {
            return View();
        }
    }
}