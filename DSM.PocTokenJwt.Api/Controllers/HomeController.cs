using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DSM.PocTokenJwt.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HomeController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Authorize]
    [Route("Get")]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }

    [HttpGet]
    [Route("Get2")]
    public IActionResult Get2()
    {
        return Ok("Hello, World! 2");
    }
}
