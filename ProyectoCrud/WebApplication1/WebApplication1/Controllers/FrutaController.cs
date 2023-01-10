using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1._02_Logica;
using WebApplication1.BDCRUD;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FrutaController : ControllerBase
    {
        FrutaLogica logica = new FrutaLogica();


        [HttpGet]
        public IActionResult get()
        {
            List<Fruta> Frutas = logica.getAll();
            return Ok(Frutas);
        }


        [HttpGet("{id}")]
        public IActionResult getByid(int id)
        {
            Fruta Fruta = logica.getById(id);
            return Ok(Fruta);
        }



        [HttpGet("filtro/{id_categoria}/{nombre}")]
        public IActionResult getByFilter(int? id_categoria, string? nombre)
        {
            List<Fruta> frutas = new List<Fruta>();
            frutas = logica.getByFilter(id_categoria, nombre);
            return Ok(frutas);
        }


        [HttpPost]
        public IActionResult create(Fruta request)
        {
            Fruta Fruta = logica.create(request);
            return Ok(Fruta);
        }

        [HttpPost("filter")]
        public IActionResult getByFilter(GenericFilterRequest filters)
        {
            GenericFilterResponse<Fruta> res = logica.getByFilterGeneric(filters);
            return Ok(res);
        }


        [HttpPut]
        public IActionResult update(Fruta request)
        {
            Fruta Fruta = logica.update(request);
            return Ok(Fruta);
        }



        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int cantidad = logica.delete(id);
            return Ok(cantidad);
        }


    }
}
