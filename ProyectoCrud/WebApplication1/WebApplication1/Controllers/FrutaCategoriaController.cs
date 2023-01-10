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
    public class FrutaCategoriaController : ControllerBase
    {
        FrutaCategoriaLogica logica = new FrutaCategoriaLogica();


        [HttpGet]
        public IActionResult get()
        {
            List<FrutaCategoria> FrutaCategorias = logica.getAll();
            return Ok(FrutaCategorias);
        }


        [HttpGet("{id}")]
        public IActionResult getByid(int id)
        {
            FrutaCategoria FrutaCategoria = logica.getById(id);
            return Ok(FrutaCategoria);
        }

        [HttpPost]
        public IActionResult create(FrutaCategoria request)
        {
            FrutaCategoria FrutaCategoria = logica.create(request);
            return Ok(FrutaCategoria);
        }


        [HttpPut]
        public IActionResult update(FrutaCategoria request)
        {
            FrutaCategoria FrutaCategoria = logica.update(request);
            return Ok(FrutaCategoria);
        }



        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int cantidad = logica.delete(id);
            return Ok(cantidad);
        }


    }
}
