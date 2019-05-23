using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Services.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Services
{
    public class ProductsServices : IProductsService
    {
        IProduct _iProduct;
        public ProductsServices(IProduct iProduct)
        {
            this._iProduct = iProduct;
        }
        public Task<Result<IEnumerable<Product>>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
