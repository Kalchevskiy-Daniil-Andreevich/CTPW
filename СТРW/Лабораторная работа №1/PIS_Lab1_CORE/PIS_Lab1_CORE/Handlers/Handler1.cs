using Microsoft.AspNetCore.Mvc;

namespace PIS_Lab1_CORE.Handlers
{
    [Route("api/KDA")]
    [ApiController]
    public class Handler1 : ControllerBase
    {
        [HttpGet] 
        public IActionResult GetHandler(string parmA, string parmB)
        {
            string response = $"===== GET =====\n" +
                      $"parmA = {(parmA != null ? parmA : "null")}\n" +
                      $"parmB = {(parmB != null ? parmB : "null")}";
            return Content(response, "text/plain");
        }
    }
}
