using Dal.Abstract.AbstractClasses;
using Dal.Exceptions;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete
{
    public sealed class PurchaseHistoryDal : ADalRead<PurchaseHistoryEntity>
    {
        protected override PurchaseHistoryEntity CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            PurchaseHistoryEntity entity = new PurchaseHistoryEntity(
            Convert.ToInt64(parameters[Convert.ToInt32(EPurchaseHistoryEntity.PRODUCT_ID)]),
            Convert.ToDateTime(parameters[Convert.ToInt32(EPurchaseHistoryEntity.DATE)]))
            {
                ID = Convert.ToInt64(parameters[Convert.ToInt32(EPurchaseHistoryEntity.ID)])
            };
            return entity;
        }

        protected override string GetTableField(string field) => field switch
        {
            "id" => "user_id",
            "product_id" => "product_id",
            "date" => "date",
            _ => throw new FieldNotFoundExeption(field)
        };

        protected override string GetTableName()
        {
            return "tblPurchaseHistory";
        }
    }
}
