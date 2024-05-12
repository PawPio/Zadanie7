﻿using Microsoft.AspNetCore.Mvc;

namespace Zadanie7.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TripController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTrips()
    {
        return Ok();
    }
}