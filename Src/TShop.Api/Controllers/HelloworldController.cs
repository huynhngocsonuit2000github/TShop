using Microsoft.AspNetCore.Mvc;

namespace TShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloworldController : ControllerBase
{ 
    private readonly ILogger<HelloworldController> _logger;

    public HelloworldController(ILogger<HelloworldController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok("Hello world");
    }
}
