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


        #endregion SECCION CRUD


    }
}
