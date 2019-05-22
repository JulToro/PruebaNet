using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet.WebApi.Adapters.Mappers
{
    public interface IMapperAdapterFactory
    {
        IMapperAdapter Create();
    }
}
