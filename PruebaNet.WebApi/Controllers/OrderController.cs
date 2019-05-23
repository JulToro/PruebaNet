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
    /// Class Order Controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/orders")]
    [EnableCors("MyPolicy")]
    public class OrderController : Controller
    {
        private IOrderService _iOrderService;
        /// <summary>
        /// Constructor controller
        /// </summary>
        /// <param name="iOrderService"></param>
        public OrderController(IOrderService iOrderService)
        {
            this._iOrderService = iOrderService;
        }

        /// <summary>
        /// Metodo encargado de obtener todas las ordenes que se han creado.
        /// </summary>
        /// <returns></returns>
        // GET: api/orders
        [HttpGet()]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get()
        {
            Result<IEnumerable<Order>> result = new Result<IEnumerable<Order>>();
            try
            {
                result = await this._iOrderService.GetAll();

            }
            catch (Exception ex)
            {
                return BadRequest($"Ocurrio un error inexperado información del error: {ex.Message}");
            }            
            return Ok(result);
        }

        /// <summary>
        /// Obtener una orden especifica
        /// </summary>
        /// <param name="id">Id de la orden</param>
        /// <returns></returns>
        // GET: api/orders
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int id)
        {
            Result<Order> result = new Result<Order>();
            try
            {
                result = await this._iOrderService.GetbyIdOrder(id);
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
        /// Registrar Orden
        /// </summary>
        /// <param name="order">Orden a registrar</param>
        /// <returns></returns>
        // POST: api/orders
        [HttpPost()]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(Order order)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                result = await this._iOrderService.Create(order);
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