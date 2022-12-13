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
    public class CategoriaController : ControllerBase
    {
        #region variables y constructor
        private readonly ICategoriaNegocio _CategoriaNegocio;
        private readonly IMapper _mapper;
        public CategoriaController(IMapper mapper)
        {
            _mapper = mapper;
            _CategoriaNegocio = new CategoriaNegocio(mapper);
        }
        #endregion

        #region SECCION CRUD

        /// <summary>
        /// Retorna una lista de Categorias
        /// </summary>
        /// <returns>Retorna una lista de Categorias</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<CategoriaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult get()
        {
            try
            {
                return Ok(_CategoriaNegocio.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Busca un Categoria por el id o conocido como el campo PK
        /// </summary>
        /// <returns>Retorna un Categoria</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CategoriaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult getById(int id)
        {
            try
            {
                return Ok(_CategoriaNegocio.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Crea un registro de Categoria
        /// </summary>
        /// <param name="request">Parametros del Categoria</param>
        /// <returns>Retorna el Categoria creado </returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CategoriaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult create([FromBody] CategoriaRequest request)
        {
            try
            {
                return Ok(_CategoriaNegocio.Create(request));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Actualiza un registro de Categoria
        /// </summary>
        /// <param name="request">Parametros del Categoria</param>
        /// <returns>Retorna el Categoria actualizado </returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CategoriaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult update([FromBody] CategoriaRequest request)
        {
            try
            {
                return Ok(_CategoriaNegocio.Update(request));
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
                return Ok(_CategoriaNegocio.delete(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Hace una inserción de multiples registros en una sola transacción
        /// </summary>
        /// <param name="request">Lista de Categorias a insertarse</param>
        /// <returns>Lista de Categorias creados</returns>
        [HttpPost("multiple")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<CategoriaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult createMultiple([FromBody] List<CategoriaRequest> request)
        {
            try
            {
                return Ok(_CategoriaNegocio.CreateMultiple(request));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Hace una actualización de multiples registros en una sola transacción
        /// </summary>
        /// <param name="request">Lista de Categorias a actualizarce</param>
        /// <returns>Lista de Categorias actualizados</returns>
        [HttpPut("multiple")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<CategoriaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ErrorResponse))]
        public IActionResult updateMultiple([FromBody] List<CategoriaRequest> request)
        {
            try
            {
                return Ok(_CategoriaNegocio.UpdateMultiple(request));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion SECCION CRUD




    }
}
