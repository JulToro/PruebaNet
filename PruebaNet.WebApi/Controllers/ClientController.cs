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
    /// Class Order 
    /// </summary>
    [Produces("application/json")]
    [Route("api/clients")]
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
        // GET: api/clients
        [HttpGet()]
        [ProducesResponseType(typeof(Result<IEnumerable<Client>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get()
        {
            Result<IEnumerable<Client>> result = new Result<IEnumerable<Client>>();
            try
            {               
                result = await this._iServiceClients.GetAll();
                if (!result.IsSuccess)
                {
                    return NotFound(result.Exception);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorrudio un error inexperado información del error: {ex.Message}");
            }
            return Ok(result);
        }

        /// <summary>
        /// Metodo encargado de obtener información de un cliente especifico.
        /// </summary>
        /// <param name="id">Id del Cliente</param>
        /// <returns></returns>
        // GET: api/clients
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Result<Client>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int id)
        {
            Result<Client> result = new Result<Client>();
            try
            {
                result = await this._iServiceClients.GetClient(id);
                if (!result.IsSuccess)
                {
                    return NotFound(result.Exception);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorrudio un error inexperado información del error: {ex.Message}");
            }
            return Ok(result);
        }
        /// <summary>
        /// Registrar Cliente
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        // POST: api/clients
        [HttpPost()]
        [ProducesResponseType(typeof(Result<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody]Client client)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                result = await this._iServiceClients.Create(client);
                if (!result.IsSuccess)
                {
                    return NotFound(result.Exception);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorrudio un error inexperado información del error: {ex.Message}");
            }
            return Ok(result);
        }

    }
}