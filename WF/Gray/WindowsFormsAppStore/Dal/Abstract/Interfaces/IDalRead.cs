using Entity.Abstract.Interfaces;
using System.Collections.Generic;

namespace Dal.Abstract.Interfaces
{
    public interface IDalRead<TEntity> where TEntity : IEntity
    {
        // Read
        TEntity GetById(long id);

        IList<TEntity> GetByFieldName(string fieldName, dynamic text);

        IList<TEntity> GetAll();

    }
}
