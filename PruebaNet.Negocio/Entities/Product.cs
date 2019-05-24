namespace PruebaNet.Negocio.Entities
{
    using PruebaNet.Negocio.Interfaces;
    using System;
    public class Product: IEntity
    {
        public Int64 idProduct { get; }
        public string nameProduct { get; }
        public double value { get; }
        public int? PLU { get; }
        public int tax { get; }
        public string commentary { get; set; }
        public Product(Int64 idProduct, string nameProduct, double value, int tax, int? PLU)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.value = value;
            this.tax = tax;
            this.PLU = PLU;
        }        
        
        public bool Validate()
        {
            if(this.idProduct == 0)
            {
                throw new Exception("The product doesn't have identification");
            }
            if (string.IsNullOrEmpty(this.nameProduct))
            {
                throw new Exception("The product doesn't have name");
            }
            if (this.value == 0)
            {
                throw new Exception("The product doesn't have value");
            }
            return true;
        }
    }
}
