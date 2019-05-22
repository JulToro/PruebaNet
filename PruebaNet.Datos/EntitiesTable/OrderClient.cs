using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class OrderClient
    {
        public int Id { get; set; }
        public Client Client { get; set; }        
        public Employee Employee { get;set; }
        public ICollection<Order> Orders { get; set; }
    }
}
