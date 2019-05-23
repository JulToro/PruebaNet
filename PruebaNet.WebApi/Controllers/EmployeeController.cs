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
    /// Controlador encargado de Empleados
    /// </summary>
    [Produces("application/json")]
    [Route("api/employees")]
    [EnableCors("MyPolicy")]
    public class EmployeeController : Controller
    {
        private IEmployeesService _iEmployeesService;
        /// <summary>
        /// Constructor controller
        /// </summary>
        /// <param name="iEmployeesService"></param>
        public EmployeeController(IEmployeesService iEmployeesService)
        {
            this._iEmployeesService = iEmployeesService;
        }
        /// <summary>
        /// Metodo encargado de obtener todas las ordenes que se han creado.
        /// </summary>
        /// <returns></returns>
        // GET: api/employees
        [HttpGet()]
        [ProducesResponseType(typeof(Result<IEnumerable<Employee>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get()
        {
            Result<IEnumerable<Employee>> result = new Result<IEnumerable<Employee>>();
            try
            {
                result = await _iEmployeesService.Get();
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
        /// <returns></returns>
        /// <param name="id">Id del Empleado</param>
        // GET: api/employees
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Result<Employee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int id)
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                result = await this._iEmployeesService.Get(id);
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