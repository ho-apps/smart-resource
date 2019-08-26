using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ResourceMaterials.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResourceMaterials.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("0.9", Deprecated = true)]
    [Route("api/v{version:apiVersion}/standart")]
    public class StandartController : Controller
    {
        // GET
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IEnumerable<Standart> Get()
        {
            var standarts = new List<Standart>
            {
                new Standart("6391", string.Empty, "ISO 639", "639-1", "коды языков"),
                new Standart("6392", string.Empty, "ISO 639", "639-2", "коды языков"),
                new Standart("6393", string.Empty, "ISO 639", "639-3", "коды языков"),
                new Standart("668", string.Empty, "ISO 668", "668", "размеры и классификация ISO-контейнеров")
            };

            return standarts;
        }

        // GET
        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public string Get(int id)
        {
            return "value";
        }

        // POST
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public void Post([FromBody]string value)
        {
        }

        // PUT 
        [HttpPut("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public void Put(int id, [FromBody]string value)
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
