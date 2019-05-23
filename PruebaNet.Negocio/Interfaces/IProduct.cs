using PruebaNet.Negocio.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Interfaces
{
    public interface IProduct
    {
        Task<Result<IEnumerable<Product>>> Get();
        Task<Result<Product>> Get(int id);
    }
}
