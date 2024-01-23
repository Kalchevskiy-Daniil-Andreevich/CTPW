using Microsoft.AspNetCore.Mvc;

namespace PIS_Lab1_CORE.Handlers
{
    [Route("api/KDA")]
    [ApiController]
    public class Handler2 : ControllerBase
    {
        [HttpPost] 
        public IActionResult PostHandler(string parmA, string parmB)
        {
            string response = $"===== POST =====\n" +
                          $"parmA = {(parmA != null ? parmA : "null")}\n" +
                          $"parmB = {(parmB != null ? parmB : "null")}";
            return Content(response, "text/plain");
        }
    }
}
