using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Datos.Repositories
{
    public class ProductRepository : IProduct
    {
        public Task<Result<IEnumerable<Product>>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Result<Product>> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
