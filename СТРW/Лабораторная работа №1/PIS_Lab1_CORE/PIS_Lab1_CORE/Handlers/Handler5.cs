using Microsoft.AspNetCore.Mvc;
using ServiceStack.Web;

namespace PIS_Lab1_CORE.Handlers
{
    [Route("api/calculator")]
    [ApiController]
    public class Handler5 : ControllerBase
    {

        [HttpGet] 
        public IActionResult Get()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Task5.html");
            return PhysicalFile(filePath, "text/html");
        }

        [HttpPost]
        public IActionResult Post([FromBody] NR request)
        {
            if (request.X == null && request.Y == null)
            {
                return BadRequest("Invalid request body");
            }

            double? result = request.X * request.Y;
            return Ok(result);
        }

        public class NR
        {
            public double? X { get; set; }
            public double? Y { get; set; }
        }
    }
}
