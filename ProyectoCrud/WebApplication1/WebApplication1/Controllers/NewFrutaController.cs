using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1._02_Logica.Implementacion;
using WebApplication1._02_Logica.Interface;
using WebApplication1.BDCRUD;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NewFrutaController : ControllerBase
    {
        private readonly IFrutaLogica<Fruta> _FrutaLogica;

        public NewFrutaController()
        {
            _FrutaLogica = new NewFrutaLogica();
        }

        [HttpGet]
        public IActionResult get()
        {
            List<Fruta> Frutas = _FrutaLogica.getAll();
            return Ok(Frutas);
        }


        [HttpGet("{id}")]
        public IActionResult getByid(int id)
        {
            Fruta Fruta = _FrutaLogica.getById(id);
            return Ok(Fruta);
        }

        [HttpPost]
        public IActionResult create(Fruta request)
        {
            Fruta Fruta = _FrutaLogica.create(request);
            return Ok(Fruta);
        }

        [HttpPost("filter")]
        public IActionResult getByFilter(GenericFilterRequest filters)
        {
            GenericFilterResponse<Fruta> res = _FrutaLogica.getByFilterGeneric(filters);
            return Ok(res);
        }


        [HttpPut]
        public IActionResult update(Fruta request)
        {
            Fruta Fruta = _FrutaLogica.update(request);
            return Ok(Fruta);
        }



        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int cantidad = _FrutaLogica.delete(id);
            return Ok(cantidad);
        }


    }
}
