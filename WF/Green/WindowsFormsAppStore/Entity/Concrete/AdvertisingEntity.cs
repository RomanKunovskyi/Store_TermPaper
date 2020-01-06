using Entity.Abstract.Interfaces;

namespace Entity.Concrete
{
    public enum EAdvertisingEntity
    {
        ID = 0,
        PURCHASE,
        COST,
        TYPE,
        INFO,
        PICTURES
    }
    public sealed class AdvertisingEntity: IEntity
    {
        public long? ID { get; set; }
        public string Purchase { get; set; }
        public double? Cost { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }
        public string Picture { get; set; }
        public AdvertisingEntity(string purchase, double? cost, string type, string info, string picture)
        {
            Purchase = purchase; Cost = cost; Type = type; Info = info; Picture = picture;
        }
    }
}
