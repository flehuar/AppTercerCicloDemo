using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1._02_Logica;
using WebApplication1.BDCRUD;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        ProductoLogica logica = new ProductoLogica();


        [HttpGet]
        public IActionResult get()
        {
            List<Producto> productos = logica.getAll();
            return Ok(productos);
        }


        [HttpGet("{id}")]
        public IActionResult getByid(int id)
        {
            Producto producto = logica.getById(id);
            return Ok(producto);
        }

        [HttpPost]
        public IActionResult create(Producto request)
        {
            Producto producto = logica.create(request);
            return Ok(producto);
        }


        [HttpPut]
        public IActionResult update(Producto request)
        {
            Producto producto = logica.update(request);
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
