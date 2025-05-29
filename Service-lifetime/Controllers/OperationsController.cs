using Microsoft.AspNetCore.Mvc;
using Service_lifetime.Services;

namespace Service_lifetime.Controllers;
[ApiController]
[Route("api/[controller]")]
public class OperationsController(
    [FromKeyedServices("First")] IOperationService firstService,
    [FromKeyedServices("Second")] IOperationService secondService,
    [FromKeyedServices("Last")] IOperationService lastService)
    : ControllerBase
{
  

    [HttpGet("first")]
    public IActionResult First()
    {
        return Ok(new
        {
            First = firstService.Operations(),
            Second = secondService.Operations(),
            Last = lastService.Operations()
        });
    }
    [HttpGet("second")]
    public IActionResult Second()
    {
        return Ok(new
        {
            First = firstService.Operations(),
            Second = secondService.Operations(),
            Last = lastService.Operations()
        });
    }
}