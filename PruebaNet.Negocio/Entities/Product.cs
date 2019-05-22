namespace PruebaNet.Negocio.Entities
{
    using PruebaNet.Negocio.Interfaces;
    using System;
    public class Product: IEntity
    {
        public Int64 _idProduct { get; }
        public string _nameProduct { get; }
        public double _value { get; }
        public int? _PLU { get; }
        public int _tax { get; }        

        public Product(Int64 idProduct, string nameProduct, double value, int tax, int? PLU)
        {
            this._idProduct = idProduct;
            this._nameProduct = nameProduct;
            this._value = value;
            this._tax = tax;
            this._PLU = PLU;
        }        
        
        public bool Validate()
        {
            if(this._idProduct == 0)
            {
                throw new Exception("The product doesn't have identification");
            }
            if (string.IsNullOrEmpty(this._nameProduct))
            {
                throw new Exception("The product doesn't have name");
            }
            if (this._value == 0)
            {
                throw new Exception("The product doesn't have value");
            }

            return true;
        }
    }
}
