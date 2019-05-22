using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Negocio.Entities
{
    public class Result<T>
    {
        public T Response { get; set; }
        public bool IsSuccess { get; set; }
        public string Exception { get; set; }

    }
}
