using Dal.Abstract.Interfaces;
using Dal.Exceptions;
using Entity.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dal.Abstract.AbstractClasses
{
    public abstract class ADalRead<TEntity> : IDalRead<TEntity> where TEntity : IEntity
    {
        protected IDictionary<ESqlQueries, string> sqlQueries;

        public ADalRead()
        {
            sqlQueries = new Dictionary<ESqlQueries, string>();
            InitReadQueries();
        }

        private void InitReadQueries()
        {
            sqlQueries.Add(ESqlQueries.GET_BY_ID, "SELECT * FROM " + GetTableName() + " WHERE {0} = @id;");
            sqlQueries.Add(ESqlQueries.GET_BY_FIELD, "SELECT * FROM " + GetTableName() + " WHERE  {0} = @value;");
            sqlQueries.Add(ESqlQueries.GET_ALL, "SELECT * FROM " + GetTableName() + ";");
        }

        protected abstract string GetTableName();
        protected abstract string GetTableField(string field); //switchCASE!!!!!!!!!!!!!!!!!
        protected abstract TEntity CreateInstance(ICollection<string> args);

        // Read
        private IList<TEntity> GetQueryResult(string query, ESqlQueries sqlQueries,SqlParameter[] Parameter=null)
        {
            IList<TEntity> all = new List<TEntity>();
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            IList<string> queryResult;
            //
            if (query == null)
            {
                throw new QueryNotFoundExeption(Enum.GetName(typeof(ESqlQueries), sqlQueries));
            }
            try
            {
                connection = ConnectionManager.ConnectionManager.Get().GetConnection();
                command = new SqlCommand(query, connection);
                ////////////////////????????????????????????????????????????
                if (Parameter != null)
                {
                    foreach (var param in Parameter)
                    {
                        command.Parameters.Add(param);
                    }
                }
                ////////////////////???????????????????????????????????????
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    queryResult = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        queryResult.Add(reader[i].ToString());
                    }
                    all.Add(CreateInstance(queryResult));
                }

            }
            catch (Exception e)
            {
                throw new DatabaseReadingExeption(e);
            }
            finally
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Open))
                {
                    connection.Close();
                }
                //?????????????????????????????????????????????????????????????????
                if(command!=null)
                {
                    command.Dispose();
                }
            }
            //if (all.Count == 0)
            //{
            //    throw new EmptyDataReaderByQueryExeption(query);
            //}
            return all;
        }

        public TEntity GetById(long id)
        {
            SqlParameter[] Parameter = new SqlParameter[] { new SqlParameter("@id", id) };
            return GetQueryResult(string.Format(sqlQueries[ESqlQueries.GET_BY_ID],GetTableField("id")), ESqlQueries.GET_BY_ID, Parameter)[0];
        }

        public IList<TEntity> GetByFieldName(string fieldName, dynamic text)
        {
            SqlParameter[] Parameter = new SqlParameter[] { new SqlParameter("@value", text) };
            return GetQueryResult(string.Format(sqlQueries[ESqlQueries.GET_BY_FIELD],GetTableField(fieldName)), ESqlQueries.GET_BY_FIELD, Parameter);
        }

        public IList<TEntity> GetAll()
        {
            return GetQueryResult(sqlQueries[ESqlQueries.GET_ALL], ESqlQueries.GET_ALL);
        }
    }
}
