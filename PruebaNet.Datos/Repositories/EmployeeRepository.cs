using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Datos.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        public Task<Result<IEnumerable<Employee>>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Result<Employee>> Get(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
