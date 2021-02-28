using Microsoft.AspNetCore.Mvc;
using System;

namespace Pizzaria.API.Controllers
{
    [Route("api/pedido")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            return Ok($"O nome digitado foi {nome}");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
