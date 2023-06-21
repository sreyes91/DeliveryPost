﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

public class ErrorsController : ControllerBase
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("/Error")]
    public IActionResult Error()
{
    Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

    return Problem();
}
}