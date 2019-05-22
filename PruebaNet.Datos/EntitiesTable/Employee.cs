using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Employee
    {
        public int Id { get; set; }        
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
