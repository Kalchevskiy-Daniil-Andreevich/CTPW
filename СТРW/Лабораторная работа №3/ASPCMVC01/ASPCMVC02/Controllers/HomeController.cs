using Microsoft.AspNetCore.Mvc;


namespace ASPCMVC02.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}