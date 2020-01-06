using Entity.Abstract.Interfaces;

namespace Dal.Abstract.Interfaces
{
    public interface IDalCrud<TEntity> : IDalRead<TEntity> where TEntity : IEntity
    {
        // Create
        int Insert(TEntity entity);

        // Update
        int UpdateByEntity(TEntity entity);

        int UpdateByFieldName(string fieldName, dynamic text, string fieldCondition, dynamic textCondition);

        // Delete
        int DeleteById(long id);

        int DeleteByFieldName(string fieldCondition, dynamic textCondition);

        int Delete(TEntity entity);
    }
}
