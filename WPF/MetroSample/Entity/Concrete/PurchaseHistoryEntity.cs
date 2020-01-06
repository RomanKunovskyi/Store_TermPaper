using Entity.Abstract.Interfaces;
using System;

namespace Entity.Concrete
{
    public enum EPurchaseHistoryEntity
    {
        ID = 0,
        PRODUCT_ID,
        DATE
    }
    public sealed class PurchaseHistoryEntity : IEntity
    {
        public long? ID { get; set; }
        public long? ProductID { get; set; }
        public DateTime Date { get; set; }
        public PurchaseHistoryEntity(long id,long productId, DateTime date)
        {
            ProductID = productId; Date = date;ID = id;
        }
    }
}
