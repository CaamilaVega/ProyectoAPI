using Microsoft.AspNetCore.Mvc;
using Negocio;
using Negocio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        ProductoAPI api = new ProductoAPI();
        // GET: api/<APIController>
        [HttpGet]
        public List<Producto> Get()
        {
            var producto = api.getAll();
            return producto;
        }

        // GET api/<APIController>/5
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            return api.getById(id);
        }

        // POST api/<APIController>
        [HttpPost]
        public Producto Post([FromBody] Producto producto)
        {
            return api.post(producto); 
        }

        // PUT api/<APIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<APIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
