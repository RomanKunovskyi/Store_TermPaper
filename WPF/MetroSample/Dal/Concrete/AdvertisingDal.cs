using Dal.Abstract.AbstractClasses;
using Dal.Exceptions;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete
{
    public sealed class AdvertisingDal : ADalRead<AdvertisingEntity>
    {
        protected override AdvertisingEntity CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            AdvertisingEntity entity = new AdvertisingEntity(
            parameters[Convert.ToInt32(EAdvertisingEntity.PURCHASE)],
            Convert.ToDouble(parameters[Convert.ToInt32(EAdvertisingEntity.COST)]),
            parameters[Convert.ToInt32(EAdvertisingEntity.TYPE)],
            parameters[Convert.ToInt32(EAdvertisingEntity.INFO)],
            parameters[Convert.ToInt32(EAdvertisingEntity.PICTURES)])
            {
                ID = Convert.ToInt64(parameters[Convert.ToInt32(EPurchaseHistoryEntity.ID)])
            };
            return entity;
        }

        protected override string GetTableField(string field)
        {
            switch (field)
            {
                case "id": return "id";
                case "purchase": return "purchase";
                case "cost": return "cost";
                case "type": return "type";
                case "info": return "info";
                case "picture": return "picture";
                default: throw new FieldNotFoundExeption(field);
            }
        }

        protected override string GetTableName()
        {
            return "tblAdvertising";
        }
    }
}
