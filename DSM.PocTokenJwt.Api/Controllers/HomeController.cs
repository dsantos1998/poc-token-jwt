using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DSM.PocTokenJwt.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HomeController : ControllerBase
{
    private ILogger<HomeController> _logger { get; init; }

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Authorize]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType<string>(StatusCodes.Status401Unauthorized)]
    [Route("Get")]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }

    [HttpGet]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [Route("Get2")]
    public IActionResult Get2()
    {
        return Ok("Hello, World! 2");
    }
}
