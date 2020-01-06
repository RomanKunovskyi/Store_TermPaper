using Entity.Abstract.Interfaces;
using System;

namespace Entity.Concrete
{
    public enum EPersonEntity
    {
        ID = 0,
        NAME,
        SURNAME,
        PHONE_NUMBER,
        BORN_DATE,
        ADDRESS
    }
    public sealed class PersonEntity:IEntity
    {
        public long? ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long? PhoneNumber { get; set; }
        public DateTime BornDate { get; set; }
        public string Address { get; set; }
        public PersonEntity(long id,string name, string surname, long phoneNumber, DateTime bornDate, string address)
        {
            ID = id; Name = name; Surname = surname; PhoneNumber = phoneNumber; BornDate = bornDate; Address = address;
        }
    }
}
