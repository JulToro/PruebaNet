﻿//using Newtonsoft.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.DTO
{
    public class EmployeeDTO
    {
        [JsonProperty(PropertyName = "IdEmpleado")]
        public Int64 identification { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
    }
}
