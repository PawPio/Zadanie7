using Microsoft.AspNetCore.Mvc;

namespace Zadanie7.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Getclient()
    {
        return Ok();
    }
}