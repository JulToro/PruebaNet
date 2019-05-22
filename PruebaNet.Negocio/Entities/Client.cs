namespace PruebaNet.Negocio.Entities
{
    using PruebaNet.Negocio.Interfaces;
    using System;
    public class Client: IEntity
    {
        public Int64 _identification { get; }
        public string _name { get; }        
        public string _email { get; }
        public string _phoneNumber { get; }
        public string _addres { get; }
        public string _city { get; }
        
        public Client(Int64 identification, string name, string email, string  phoneNumber, string addres, string city)
        {
            this._identification = identification;
            this._name = name;
            this._email = email;
            this._phoneNumber = phoneNumber;
            this._addres = addres;
            this._city = city;
        }

        public bool Validate()
        {
            if(this._identification == 0)
            {
                throw new Exception("The client doesn't have identification");
            }
            if (this._identification == 0)
            {
                throw new Exception("The client doesn't have name");
            }
            return true;
        }
    }
}
