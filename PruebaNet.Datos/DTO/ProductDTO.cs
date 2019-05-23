//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.DTO
{
    public class ProductDTO
    {
        //[JsonProperty(PropertyName = "idProduct")]
        public Int64 idProduct { get; set; }
        //[JsonProperty(PropertyName = "nameProduct")]
        public string nameProduct { get; set; }
        //[JsonProperty(PropertyName = "value")]
        public double value { get; set; }
        //[JsonProperty(PropertyName = "PLU")]
        public int? PLU { get; set; }
        //[JsonProperty(PropertyName = "tax")]
        public int tax { get; set; }
        //[JsonProperty(PropertyName = "commentary")]
        public string commentary { get; set; }
    }
}
