namespace PruebaNet.Negocio.Entities
{
    using PruebaNet.Negocio.Interfaces;
    using System;
    using System.Runtime.Serialization;

    public class Client: IEntity
    {
        public Int64 identification { get; }
        [DataMember]
        public string name { get; }
        [DataMember]
        public string email { get; }
        [DataMember]
        public string phoneNumber { get; }
        [DataMember]
        public string addres { get; }
        [DataMember]
        public string city { get; }
        
        public Client(Int64 identification, string name, string email, string  phoneNumber, string addres, string city)
        {
            this.identification = identification;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.addres = addres;
            this.city = city;
        }

        public bool Validate()
        {
            if(this.identification == 0)
            {
                throw new Exception("The client doesn't have identification");
            }
            if (String.IsNullOrEmpty(this.name))
            {
                throw new Exception("The client doesn't have name");
            }
            return true;
        }
    }
}
