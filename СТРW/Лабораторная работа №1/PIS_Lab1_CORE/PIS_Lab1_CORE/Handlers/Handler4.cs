using Microsoft.AspNetCore.Mvc;

namespace PIS_Lab1_CORE.Handlers
{
    [Route("api/calculator")]
    [ApiController]
    public class Handler4 : ControllerBase
    {
        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] NR request)
        {

            double? sum = request.X + request.Y;
            return Ok(sum);
        }

        public class NR
        { 
            public double? X { get; set; }
            public double? Y { get; set; }
        }
    }
}
