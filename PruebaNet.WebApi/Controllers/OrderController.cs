using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;

namespace PruebaNet.WebApi.Controllers
{
    /// <summary>
    /// Class Order Controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
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
        // GET: api/[controller]
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
            } catch(Exception ex)
            {
                return NotFound();
            }            
            return Ok(result);
        }

        /// <summary>
        /// Obtener una orden especifica
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        // GET: api/[controller]
        [HttpGet("{Order/{OrderId}")]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int OrderId)
        {
            Result<IEnumerable<Order>> result = new Result<IEnumerable<Order>>();
            try
            {
                result = await this._iOrderService.GetAll();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(result);
        }
        
        /// <summary>
        /// Registrar Orden
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        // POST: api/[controller]
        [HttpPost()]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(Order order)
        {
            Result<IEnumerable<Order>> result = new Result<IEnumerable<Order>>();
            try
            {
                result = await this._iOrderService.GetAll();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(result);
        }

    }
}