using Dal.Abstract.AbstractClasses;
using Dal.Exceptions;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete
{
    public sealed class UserDal : ADalCrud<UserEntity>
    {
        public UserDal() : base() { }
        protected override UserEntity CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            UserEntity entity = new UserEntity(
            parameters[Convert.ToInt32(EUserEntity.NICKNAME)],
            parameters[Convert.ToInt32(EUserEntity.PASSWORD)])
            {
                ID = Convert.ToInt64(parameters[Convert.ToInt32(EUserEntity.ID)])
            };
            return entity;
        }
        protected override IDictionary<Enum, (string field, string pvalue, dynamic value)> GetKeyFieldsValues(UserEntity entity)
        {
            IDictionary<Enum, (string field, string pvalue, dynamic value)> Dictionary = new Dictionary<Enum, (string field, string pvalue, dynamic value)>();
            if (entity.ID.HasValue)
            {
                Dictionary.Add(EUserEntity.ID, ("id", "@id", entity.ID));
            }
            if (entity.Nickname != null)
            {
                Dictionary.Add(EUserEntity.NICKNAME, ("nickname", "@nickname", entity.Nickname));
            }
            if (entity.Password != null)
            {
                Dictionary.Add(EUserEntity.PASSWORD, ("password", "@password", entity.Password));
            }
            return Dictionary;
        }

        protected override string GetTableField(string field)
        {
            switch (field)
            {
                case "id": return "id";
                case "nickname": return "nickname";
                case "password": return "password";
                default: throw new FieldNotFoundExeption(field);
            }
        }

        protected override string GetTableName()
        {
            return "tblUser";
        }
    }
}
