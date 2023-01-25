using Microsoft.AspNetCore.Mvc;

namespace StoreTrybe.API.Controllers;

[ApiController]
[Route("v1/clientes")]
public class ClienteController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public ActionResult cliente()
    {
        return Ok();
    }
}
