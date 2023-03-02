using Microsoft.AspNetCore.Mvc;

namespace SpeedTestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SpeedTestController : ControllerBase
{
    // Get speedtest/ping
    [Route("ping")]
    [HttpGet]
    public string Ping()
    {
        return "PONG";
    }
}
