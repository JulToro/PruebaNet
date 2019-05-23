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
    /// Class Order 
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class ClientController : Controller
    {
        private IClientsServices _iServiceClients;
        /// <summary>
        /// Constructor controller
        /// </summary>
        /// <param name="iServiceClients"></param>
        public ClientController(IClientsServices iServiceClients)
        {
            this._iServiceClients = iServiceClients;
        }
        /// <summary>
        /// Metodo encargado de obtener todas las ordenes que se han creado.
        /// </summary>
        /// <returns></returns>
        // GET: api/FuelPerformance
        [HttpGet()]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get()
        {
            Result<IEnumerable<Client>> result = new Result<IEnumerable<Client>>();
            try
            {
                result = await this._iServiceClients.GetAll();
            }
            catch (Exception ex)
            {
                return NotFound($"Ocorrudio un error inexperado información del error: {ex.Message}");
            }
            return Ok(result);
        }
        /// <summary>
        /// Metodo encargado de obtener información de un cliente especifico.
        /// </summary>
        /// <returns></returns>
        // GET: api/FuelPerformance
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int id)
        {
            Result<IEnumerable<Client>> result = new Result<IEnumerable<Client>>();
            try
            {
                result = await this._iServiceClients.GetAll();
            }
            catch (Exception ex)
            {
                return NotFound($"Ocorrudio un error inexperado información del error: {ex.Message}");
            }
            return Ok(result);
        }
        /// <summary>
        /// Registrar Orden
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        // POST: api/[controller]
        [HttpPost()]
        [ProducesResponseType(typeof(Result<IEnumerable<Order>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody]Client client)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                result = await this._iServiceClients.Create(client);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(result);
        }

    }
}