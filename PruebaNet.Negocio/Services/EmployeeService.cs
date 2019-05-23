using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Services.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Services
{
    public class EmployeeService : IEmployeesService
    {
        IEmployeesService _iEmployee;
        public EmployeeService(IEmployeesService iEmployee)
        {
            this._iEmployee = iEmployee;
        }
        public async  Task<Result<IEnumerable<Employee>>> Get()
        {
            return await _iEmployee.Get();
        }

        public async Task<Result<Employee>> Get(int employeeId)
        {
            return await _iEmployee.Get(employeeId);
        }
    }
}
