using AppTercerCicloDemo01.DBTercerCiclo;
using AppTercerCicloDemo01.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppTercerCicloDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private ProductoRepositorio _repo = new ProductoRepositorio();


        /*
         1 verbo
         */
        [HttpGet]
        public IActionResult get()
        {
            try
            {
                return Ok(_repo.getAll());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            try
            {
                return Ok(_repo.getById(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        public IActionResult create([FromBody] Producto request)
        {
            try
            {
                return Ok(_repo.create(request));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPut]
        public IActionResult update([FromBody] Producto request)
        {
            try
            {
                return Ok(_repo.update(request));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            try
            {
                return Ok(_repo.delete(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
