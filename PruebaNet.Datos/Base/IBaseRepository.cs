using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace PruebaNet.Datos.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T> Get(long id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
