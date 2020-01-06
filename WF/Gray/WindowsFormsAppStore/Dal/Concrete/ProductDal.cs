using Dal.Abstract.AbstractClasses;
using Dal.Exceptions;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Concrete
{
    public sealed class ProductDal : ADalRead<ProductEntity>
    {
        protected override ProductEntity CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            ProductEntity entity = new ProductEntity(
            parameters[Convert.ToInt32(EProductEntity.NAME)],
            Convert.ToDouble(parameters[Convert.ToInt32(EProductEntity.COST)]),
            parameters[Convert.ToInt32(EProductEntity.TYPE)],
            parameters[Convert.ToInt32(EProductEntity.BRAND)])
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
                case "name": return "name";
                case "cost": return "cost";
                case "type": return "type";
                case "brand": return "brand";
                default: throw new FieldNotFoundExeption(field);
            }
        }

    protected override string GetTableName()
        {
            return "tblProduct";
        }
    }
}
