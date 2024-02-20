using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AcessController : ControllerBase
{
    [HttpGet]
    [Authorize(Policy = "MinimalAge")]
    public IActionResult Get()
    {
        return Ok("Authorize acess");
    }
}