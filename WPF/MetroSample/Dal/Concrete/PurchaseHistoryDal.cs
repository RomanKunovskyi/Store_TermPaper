using Dal.Abstract.AbstractClasses;
using Dal.Exceptions;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete
{
    public sealed class PurchaseHistoryDal : ADalCrud<PurchaseHistoryEntity>
    {
        protected override PurchaseHistoryEntity CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            PurchaseHistoryEntity entity = new PurchaseHistoryEntity(Convert.ToInt64(parameters[Convert.ToInt32(EPurchaseHistoryEntity.ID)]),
            Convert.ToInt64(parameters[Convert.ToInt32(EPurchaseHistoryEntity.PRODUCT_ID)]),
            Convert.ToDateTime(parameters[Convert.ToInt32(EPurchaseHistoryEntity.DATE)]));
            return entity;
        }

        protected override IDictionary<Enum, (string field, string pvalue, dynamic value)> GetKeyFieldsValues(PurchaseHistoryEntity entity)
        {
            IDictionary<Enum, (string field, string pvalue, dynamic value)> Dictionary = new Dictionary<Enum, (string field, string pvalue, dynamic value)>();
            if (entity.ID.HasValue)
            {
                Dictionary.Add(EPurchaseHistoryEntity.ID, ("user_id", "@id", entity.ID));
            }
            if (entity.ProductID.HasValue)
            {
                Dictionary.Add(EPurchaseHistoryEntity.PRODUCT_ID, ("product_id", "@product_id", entity.ProductID));
            }
            if (entity.Date != null)
            {
                Dictionary.Add(EPurchaseHistoryEntity.DATE, ("date", "@date", entity.Date));
            }
            return Dictionary;
        }

        protected override string GetTableField(string field)
        {
            switch (field)
            {
                case "id": return "user_id";
                case "product_id": return "product_id";
                case "date": return "date";
                default: throw new FieldNotFoundExeption(field);
            }
        }

        protected override string GetTableName()
        {
            return "tblPurchaseHistory";
        }
    }
}
