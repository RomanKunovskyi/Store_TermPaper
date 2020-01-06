using Dal.Abstract.AbstractClasses;
using Dal.Exceptions;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete
{
    public sealed class PersonDal : ADalCrud<PersonEntity>
    {
        protected override PersonEntity CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            PersonEntity entity = new PersonEntity(
            Convert.ToInt64(parameters[Convert.ToInt32(EPersonEntity.ID)]),
            parameters[Convert.ToInt32(EPersonEntity.NAME)],
            parameters[Convert.ToInt32(EPersonEntity.SURNAME)],
            Convert.ToInt64(parameters[Convert.ToInt32(EPersonEntity.PHONE_NUMBER)]),
            Convert.ToDateTime(parameters[Convert.ToInt32(EPersonEntity.BORN_DATE)]),
            parameters[Convert.ToInt32(EPersonEntity.ADDRESS)]);
            return entity;
        }

        protected override IDictionary<Enum, (string field, string pvalue, dynamic value)> GetKeyFieldsValues(PersonEntity entity)
        {
            IDictionary<Enum, (string field, string pvalue, dynamic value)> Dictionary = new Dictionary<Enum, (string field, string pvalue, dynamic value)>();
            if (entity.ID.HasValue)
            {
                Dictionary.Add(EPersonEntity.ID, ("user_id", "@id", entity.ID));
            }
            if (entity.Name != null)
            {
                Dictionary.Add(EPersonEntity.NAME, ("name", "@name", entity.Name));
            }
            if (entity.Surname != null)
            {
                Dictionary.Add(EPersonEntity.SURNAME, ("surname", "@surname", entity.Surname));
            }
            if(entity.PhoneNumber!=null)
            {
                Dictionary.Add(EPersonEntity.PHONE_NUMBER, ("phone_number", "@phone_number", entity.PhoneNumber));
            }
            if (entity.BornDate != null)
            {
                Dictionary.Add(EPersonEntity.BORN_DATE, ("born_date", "@born_date", entity.BornDate));
            }
            if (entity.Address != null)
            {
                Dictionary.Add(EPersonEntity.ADDRESS, ("address", "@address", entity.Address));
            }
            return Dictionary;
        }

        protected override string GetTableField(string field) => field switch
        {
            "id" => "user_id",
            "name" => "name",
            "surname" => "surname",
            "phone_number" => "phone_number",
            "born_date" => "born_date",
            "address" => "address",
            _ => throw new FieldNotFoundExeption(field)
        };

        protected override string GetTableName()
        {
            return "tblPerson";
        }
    }
}
