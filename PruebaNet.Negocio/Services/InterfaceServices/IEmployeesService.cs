using PruebaNet.Negocio.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Services.InterfaceServices
{
    public interface IEmployeesService
    {
        Task<Result<IEnumerable<Employee>>> Get();
        Task<Result<Employee>> Get(int employeeId);
    }
}
