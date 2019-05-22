using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.Adapters.Mappers
{
    public interface IMapperAdapterFactory
    {
        IMapperAdapter Create();
    }
}
