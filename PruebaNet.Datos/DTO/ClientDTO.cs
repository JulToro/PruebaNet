//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.DTO
{
    public class ClientDTO
    {
        //[JsonProperty(PropertyName = "identification")]
        public Int64 identification { get; set; }
        //[JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        //[JsonProperty(PropertyName = "email")]
        public string email { get; set; }
        //[JsonProperty(PropertyName = "phoneNumber")]
        public string phoneNumber { get; set; }
        //[JsonProperty(PropertyName = "identification")]
        public string addres { get; set; }
        //[JsonProperty(PropertyName = "identification")]
        public string city { get; set; }
    }
}
