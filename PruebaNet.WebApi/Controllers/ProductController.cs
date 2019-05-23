using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Services.InterfaceServices;

namespace PruebaNet.WebApi.Controllers
{
    /// <summary>
    /// Controlador encargado de Consultar Productos
    /// </summary>
    [Produces("application/json")]
    [Route("api/products")]
    [EnableCors("MyPolicy")]
    public class ProductController : Controller
    {
        private IProductsService _iProductsService;
        /// <summary>
        /// Constructor controller
        /// </summary>
        /// <param name="iOrderService"></param>
        public ProductController(IProductsService iOrderService)
        {
            this._iProductsService = iOrderService;
        }

        /// <summary>
        /// Metodo encargado de obtener todos los productos.
        /// </summary>
        /// <returns></returns>
        // GET: api/products
        [HttpGet()]
        [ProducesResponseType(typeof(Result<IEnumerable<Product>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get()
        {
            Result<IEnumerable<Product>> result = new Result<IEnumerable<Product>>();
            try
            {
                result = await this._iProductsService.Get();
                if (!result.IsSuccess)
                {
                    return NotFound(result.Exception);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocurrio un error inexperado información del error: {ex.Message}");
            }
            return Ok(result);
        }

        /// <summary>
        /// Metodo encargado de obtener todos los productos.
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <returns></returns>
        // GET: api/products
        [HttpGet()]
        [ProducesResponseType(typeof(Result<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int id)
        {
            Result<Product> result = new Result<Product>();
            try
            {
                result = await this._iProductsService.Get(id);
                if (!result.IsSuccess)
                {
                    return NotFound(result.Exception);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocurrio un error inexperado información del error: {ex.Message}");
            }
            return Ok(result);
        }
    }
}