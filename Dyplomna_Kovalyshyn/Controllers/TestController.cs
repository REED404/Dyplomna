using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dyplomna_Kovalyshyn.Controllers
{
    [Route("api/misc/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Ping()
        {
            return Ok("Pong");
        }
    }
}