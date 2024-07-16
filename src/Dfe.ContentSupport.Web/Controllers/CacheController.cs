﻿using Dfe.ContentSupport.Web.Models.Mapped;
using Dfe.ContentSupport.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dfe.ContentSupport.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CacheController(ICacheService<List<CsPage>> cache) : Controller
{
    [HttpGet]
    [Route("clear")]
    public IActionResult Clear()
    {
        cache.ClearCache();

        return Ok();
    }
}