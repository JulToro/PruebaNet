using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Utils.Entities
{
    public class StorageSettings
    {
        public Storage Storage { get; set; }
    }

    public class Storage
    {
        public string ConnectionString { get; set }
    }

}
