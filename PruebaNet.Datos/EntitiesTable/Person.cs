using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Person: BaseEntity
    {
        public int Identification { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }

        public  Client Client { get; set; }
        public  Employee Employee { get; set; }


    }
}
