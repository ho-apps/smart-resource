using System;
using Microsoft.AspNetCore.Mvc;
using ResourceMaterials.Api.Models;
using ResourceMaterials.Api.Models.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResourceMaterials.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("0.9", Deprecated = true)]
    [Route("api/v{version:apiVersion}/characteristic")]
    public class CharacteristicController : Controller
    {
        // GET
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IEnumerable<Characteristic> Get()
        {
            var ct = new CharacteristicType($"{Guid.NewGuid():N}", string.Empty, "Базовая");

            var c = new Characteristic($"{Guid.NewGuid():N}", string.Empty, "Энергпотребление", ct);
            var data = new List<Characteristic> {c, c, c};

            return data;
        }

        // GET
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAsync(string id)
        {
            await Task.Delay(2);

            var ct = new CharacteristicType("0", string.Empty, "Базовая");

            var c = new Characteristic("0", string.Empty, "Энергпотребление", ct);

            return Ok(c);

        }

        // POST
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public void Post([FromBody]Characteristic value)
        {
        }

        // PUT 
        [HttpPut("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public void Put(string id, [FromBody]Characteristic value)
        {
        }

        // DELETE
        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public void Delete(int id)
        {
        }
    }
}
