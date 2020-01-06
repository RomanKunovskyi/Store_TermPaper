using Entity.Abstract.Interfaces;

namespace Entity.Concrete
{
    public enum EProductEntity
    {
        ID = 0,
        NAME,
        COST,
        TYPE,
        BRAND
    }
    public sealed class ProductEntity:IEntity
    {
        public long? ID { get; set; }
        public string Name { get; set; }
        public double? Cost { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }

        public ProductEntity(string name, double cost, string type, string brand)
        {
             Name = name; Cost = cost; Type = type; Brand = brand;
        }
    }
}
