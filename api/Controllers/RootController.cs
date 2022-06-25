using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("/")]
public class RootController : ControllerBase
{
    public IActionResult Get()
    {
       return Ok("In API!");
    }
}
