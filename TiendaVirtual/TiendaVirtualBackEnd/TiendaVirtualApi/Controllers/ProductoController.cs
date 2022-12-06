using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Comun;
using Negocio;
using NegocioInterface;
using System.Net;
namespace TiendaVirtualApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        #region variables y constructor
        private readonly IProductoNegocio _productoNegocio;
        private readonly IMapper _mapper;
        public ProductoController(IMapper mapper)
        {
            _mapper = mapper;
            _productoNegocio = new ProductoNegocio(mapper);
        }
        #endregion

        #region SECCION CRUD

        /// <summary>
        /// Retorna una lista de productos
        /// </summary>
        /// <returns>Retorna una lista de productos</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ProductoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult get()
        {
            try
            {
                return Ok(_productoNegocio.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Busca un producto por el id o conocido como el campo PK
        /// </summary>
        /// <returns>Retorna un producto</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult getById(int id)
        {
            try
            {
                return Ok(_productoNegocio.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Crea un registro de producto
        /// </summary>
        /// <param name="request">Parametros del producto</param>
        /// <returns>Retorna el producto creado </returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult create([FromBody] ProductoRequest request)
        {
            try
            {
                return Ok(_productoNegocio.Create(request));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Actualiza un registro de producto
        /// </summary>
        /// <param name="request">Parametros del producto</param>
        /// <returns>Retorna el producto actualizado </returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult update([FromBody] ProductoRequest request)
        {
            try
            {
                return Ok(_productoNegocio.Update(request));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Elimina el registro de la base de datos por el ID o PK, correspondiente
        /// </summary>
        /// <returns>cantidad de registros afectados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(int))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult delete(int id)
        {
            try
            {
                return Ok(_productoNegocio.delete(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Hace una inserción de multiples registros en una sola transacción
        /// </summary>
        /// <param name="request">Lista de productos a insertarse</param>
        /// <returns>Lista de productos creados</returns>
        [HttpPost("multiple")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ProductoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult createMultiple([FromBody] List<ProductoRequest> request)
        {
            try
            {
                return Ok(_productoNegocio.CreateMultiple(request));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Hace una actualización de multiples registros en una sola transacción
        /// </summary>
        /// <param name="request">Lista de productos a actualizarce</param>
        /// <returns>Lista de productos actualizados</returns>
        [HttpPut("multiple")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ProductoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult updateMultiple([FromBody] List<ProductoRequest> request)
        {
            try
            {
                return Ok(_productoNegocio.UpdateMultiple(request));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion SECCION CRUD


    }
}
