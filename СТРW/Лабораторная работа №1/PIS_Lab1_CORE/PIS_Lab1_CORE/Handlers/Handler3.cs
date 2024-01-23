using Microsoft.AspNetCore.Mvc;

namespace PIS_Lab1_CORE.Handlers
{
    [Route("api/KDA")]
    [ApiController]
    public class Handler3 : ControllerBase
    {
        [HttpPut] 
        public IActionResult PUTHandler(string parmA, string parmB)
        {
            string response = $"===== PUT =====\n" +
                          $"parmA = {(parmA != null ? parmA : "null")}\n" +
                          $"parmB = {(parmB != null ? parmB : "null")}";
            return Content(response, "text/plain");
        }
    }
}
