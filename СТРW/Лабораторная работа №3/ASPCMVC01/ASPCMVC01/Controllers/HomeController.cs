using Microsoft.AspNetCore.Mvc;


namespace ASPCMVC01.Controllers
{
    public class HomeController : Controller
    {
        [Route("index.html")]
        public ActionResult Index()
        {
            return View();
        }
    }
}