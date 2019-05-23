//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.DTO
{
    public class OrderDTO
    {
        //[JsonProperty(PropertyName = "clientId")]
        public Int64 clientId { get; set; }
        //[JsonProperty(PropertyName = "employeeId")]
        public Int64 employeeId { get; set; }
        //[JsonProperty(PropertyName = "products")]
        public List<ProductDTO> products { get; set; }
        //[JsonProperty(PropertyName = "commentary")]
        public string commentary { get; set; }
        //[JsonProperty(PropertyName = "totalOrder")]
        public string totalOrder { get; set; }
    }
}
