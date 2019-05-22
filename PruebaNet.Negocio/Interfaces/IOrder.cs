using System;

namespace PruebaNet.Negocio.Interfaces
{
    public interface IOrder: IEntity
    {
        Double GetTotalOrder();
    }
}
