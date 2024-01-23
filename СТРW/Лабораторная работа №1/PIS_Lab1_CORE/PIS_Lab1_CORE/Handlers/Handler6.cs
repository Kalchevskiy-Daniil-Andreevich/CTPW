using Microsoft.AspNetCore.Mvc;
using ServiceStack;
using ServiceStack.Web;

namespace PIS_Lab1_CORE.Handlers
{
    [Microsoft.AspNetCore.Mvc.Route("api/web")]
    [ApiController]
    public class Handler6 : ControllerBase
    {

        [HttpGet] 
        public IActionResult Get(string parmA, string parmB)
        {
            int result = Int32.Parse(parmA) * Int32.Parse(parmB);
            string response = "<html>" +
                         "<head>" +
                             "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css\">" +                                                                 //строковой интерполяции 
                         "</head>" +
                         "<body>" +
                             $"<h1 class='m-5 text-center'>{parmA} * {parmB} = {result}</h1>" +
                         "</body>" +
                       "</html>";
            return Content(response, "text/html");
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
