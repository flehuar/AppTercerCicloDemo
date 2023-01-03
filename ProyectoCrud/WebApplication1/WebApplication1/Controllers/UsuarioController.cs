using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1._02_Logica;
using WebApplication1.BDCRUD;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {

        UsuarioLogica logica = new UsuarioLogica();


        [HttpGet]
        public IActionResult get()
        {
            List<Usuario> productos = logica.getAll();
            return Ok(productos);
        }


        [HttpGet("{id}")]
        public IActionResult getByid(int id)
        {
            Usuario producto = logica.getById(id);
            return Ok(producto);
        }

        [HttpPost]
        public IActionResult create(Usuario request)
        {
            Usuario producto = logica.create(request);
            return Ok(producto);
        }


        [HttpPut]
        public IActionResult update(Usuario request)
        {
            Usuario producto = logica.update(request);
            return Ok(producto);
        }



        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int cantidad = logica.delete(id);
            return Ok(cantidad);
        }


    }
}
