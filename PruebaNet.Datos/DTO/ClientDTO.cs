//using Newtonsoft.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.DTO
{
    public class ClientDTO
    {
        [JsonProperty(PropertyName = "Cedula")]
        public Int64 identification { get; set; }
        [JsonProperty(PropertyName = "Nombre")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "Email")]
        public string email { get; set; }
        [JsonProperty(PropertyName = "Telefono")]
        public string phoneNumber { get; set; }
        [JsonProperty(PropertyName = "Direccion")]
        public string addres { get; set; }
        [JsonProperty(PropertyName = "Ciudad")]
        public string city { get; set; }
    }
}
