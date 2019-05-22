﻿using System;
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
        private IServiceClients _iServiceClients;
        /// <summary>
        /// Constructor controller
        /// </summary>
        /// <param name="iServiceClients"></param>
        public ClientController(IServiceClients iServiceClients)
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
            Result<IEnumerable<Order>> result = new Result<IEnumerable<Order>>();
            try
            {
                result = await this._iServiceClients.GetAll();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok(result);
        }


    }
}