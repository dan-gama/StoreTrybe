using Microsoft.AspNetCore.Mvc;
using StoreTrybe.API.Services;

namespace StoreTrybe.API.Controllers;

[ApiController]
[Route("v1/clientes")]
public class ClienteController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public ActionResult cliente()
    {
        ClienteService serviceCliente = new ClienteService();
        var retorno = serviceCliente.GetAll();

        return Ok(retorno);

    }
}
