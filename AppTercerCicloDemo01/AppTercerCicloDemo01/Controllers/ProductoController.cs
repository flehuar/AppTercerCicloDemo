using AppTercerCicloDemo01.CommonModel;
using AppTercerCicloDemo01.DBTercerCiclo;
using AppTercerCicloDemo01.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AppTercerCicloDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private ProductoRepositorio _repo = new ProductoRepositorio();

        /// <summary>
        /// Retorna una lista de productos
        /// </summary>
        /// <returns>Retorna una lista de productos</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Producto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
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

        /// <summary>
        /// Retorna un producto por el ID ==> PK Correspondiente
        /// </summary>
        /// <param name="id">Primary key del producto</param>
        /// <returns>objeto producto</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Producto))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
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

        /// <summary>
        /// Inserta un registro de producto
        /// </summary>
        /// <param name="request">objeto producto</param>
        /// <returns>objeto producto</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Producto))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
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

        /// <summary>
        /// Actualiza un registro de producto
        /// </summary>
        /// <param name="request">objeto producto</param>
        /// <returns>objeto producto</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Producto))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
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


        /// <summary>
        /// Elimina el registro de la tabla
        /// </summary>
        /// <param name="id">PK del producto a eliminar</param>
        /// <returns>Cantidad de registros afectados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(int))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
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
