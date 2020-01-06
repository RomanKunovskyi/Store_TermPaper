namespace Entity.Abstract.Interfaces
{
    public enum EIEntity { ID };//to remove id from entity enums
    public interface IEntity
    {
        long? ID { get; set; }
    }
}

