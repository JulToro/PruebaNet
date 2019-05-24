using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaNet.Datos.DTO;
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
        public async Task<ActionResult> Get([FromQuery] int? clientId, [FromQuery] int? employeeId)
        {
            Result<IEnumerable<OrderDTO>> result = new Result<IEnumerable<OrderDTO>>();
            try
            {
                if (!clientId.HasValue && !employeeId.HasValue)
                {
                    //Return all order
                    //result = await this._iOrderService.GetAll();
                }

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
        [ProducesResponseType(typeof(Result<OrderDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int id)
        {
            Result<OrderDTO> result = new Result<OrderDTO>();
            try
            {
                Result<Order> orderReturn = await this._iOrderService.GetbyIdOrder(id);
                if (orderReturn.IsSuccess)
                {
                    OrderDTO order = CastOrdertoOrderDTO(orderReturn);

                    result.IsSuccess = true;
                    result.Response = order;
                }
                else
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
        [Consumes("application/json")]
        [ProducesResponseType(typeof(Result<IEnumerable<OrderDTO>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody]OrderDTO order)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                List<Product> listProducts = new List<Product>();

                foreach (var item in order.products)
                {
                    Product product = new Product(item.idProduct, item.nameProduct, item.value, item.tax, item.PLU);
                    product.commentary = item.commentary;
                    listProducts.Add(product);
                }

                Order newOrder = new Order(order.clientId, order.employeeId, listProducts, order.commentary); ;
                result = await this._iOrderService.Create(newOrder);
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
        private static OrderDTO CastOrdertoOrderDTO(Result<Order> orderReturn)
        {
            OrderDTO order = new OrderDTO();
            order.clientId = orderReturn.Response.clientId;
            order.commentary = orderReturn.Response.commentary;
            order.employeeId = orderReturn.Response.employeeId;
            order.totalOrder = orderReturn.Response.GetTotalOrder().ToString();

            List<ProductDTO> listProducts = new List<ProductDTO>();
            foreach (var item in orderReturn.Response.products)
            {
                ProductDTO product = new ProductDTO();
                product.idProduct = item.idProduct;
                product.nameProduct = item.nameProduct;
                product.tax = item.tax;
                product.value = item.value;
                product.PLU = item.PLU;
            }

            order.products.AddRange(listProducts);
            return order;
        }

    }
}