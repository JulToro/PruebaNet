using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;

namespace PruebaNet.WebApi.Controllers
{
    /// <summary>
    /// Controlador encargado de Empleados
    /// </summary>
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
        // GET: api/FuelPerformance
        [HttpGet()]
        [ProducesResponseType(typeof(Result<IEnumerable<Employee>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get()
        {
            Result<IEnumerable<Employee>> result = new Result<IEnumerable<Employee>>();
            try
            {
               
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
        [ProducesResponseType(typeof(Result<IEnumerable<Employee>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Get(int id)
        {
            Result<IEnumerable<Employee>> result = new Result<IEnumerable<Employee>>();
            try
            {
                //result = await this._iServiceClients.GetAll();
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
        /// <param name="employee"></param>
        /// <returns></returns>
        // POST: api/[controller]
        [HttpPost()]
        [ProducesResponseType(typeof(Result<IEnumerable<Employee>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(Employee employee)
        {
            Result<IEnumerable<bool>> result = new Result<IEnumerable<bool>>();
            try
            {
                // result = await this._iOrderService.GetAll();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(result);
        }
    }
}