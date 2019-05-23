using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Client: BaseEntity
    {
        public int Identification { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public virtual OrderClient OrderClient { get; set; }
    }
}
