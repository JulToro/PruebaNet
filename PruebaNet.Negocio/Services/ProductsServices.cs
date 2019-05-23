using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using PruebaNet.Negocio.Services.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Services
{
    public class ProductsServices : IProductsService
    {
        private readonly IProduct _iProduct;
        public ProductsServices(IProduct iProduct)
        {
            this._iProduct = iProduct;
        }
        public async Task<Result<IEnumerable<Product>>> Get()
        {
            return await _iProduct.Get();
        }

        public async Task<Result<Product>> Get(int id)
        {
            return await _iProduct.Get(id);
        }
    }
}
