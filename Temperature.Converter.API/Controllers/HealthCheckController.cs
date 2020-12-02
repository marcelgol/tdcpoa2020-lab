using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public HttpStatusCode Post()
        {
            return HttpStatusCode.OK;
        }

    }
}
