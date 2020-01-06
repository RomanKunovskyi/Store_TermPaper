using Dal.Abstract.Interfaces;
using Dal.Exceptions;
using Entity.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dal.Abstract.AbstractClasses
{
    public abstract class ADalCrud<TEntity> : ADalRead<TEntity>, IDalCrud<TEntity> where TEntity : IEntity
    {
        public ADalCrud() : base()
        {
            InitCrudQueries();
        }

        private void InitCrudQueries()///////////////////////////!!!!!! not like {0}
        {
            sqlQueries.Add(ESqlQueries.INSERT, "INSERT INTO " + GetTableName() + " ({0}) VALUES({1});");
            sqlQueries.Add(ESqlQueries.UPDATE_BY_ID, "UPDATE " + GetTableName() + " SET {0} WHERE {1} = @id;");
            sqlQueries.Add(ESqlQueries.UPDATE_BY_FIELD, "UPDATE " + GetTableName() + " SET {0} = @value WHERE {1} = @condition;");
            sqlQueries.Add(ESqlQueries.DELETE_BY_ID, "DELETE FROM " + GetTableName() + " WHERE {0} = @id;");
            sqlQueries.Add(ESqlQueries.DELETE_BY_FIELD, "DELETE FROM " + GetTableName() + " WHERE {0} = @value;");
        }

        protected abstract IDictionary<Enum, (string field,string pvalue, dynamic value)> GetKeyFieldsValues(TEntity entity);    //EIEntity,("field","@value","value")

        // Execute Query
        private int ExecuteQuery(string query, ESqlQueries sqlQueries,List<SqlParameter> Parameters=null)
        {
            int result = 0;
            SqlConnection connection = null;
            SqlCommand command = null;
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
                if (Parameters != null)
                {
                    foreach(var param in Parameters)
                    {
                        command.Parameters.Add(param);
                    }
                }
                ////////////////////???????????????????????????????????????
                connection.Open();
                result = command.ExecuteNonQuery();
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
                ////////??????????????????????
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return result;
        }

        // Create
        public int Insert(TEntity entity)
        {
            string insertFields = string.Empty;
            string insertValues = string.Empty;
            IDictionary<Enum, (string field, string pvalue,dynamic value)> entityValues = GetKeyFieldsValues(entity);
            List<SqlParameter> Parameters = new List<SqlParameter>();

            foreach (KeyValuePair<Enum, (string field, string pvalue, dynamic value)> kvp in entityValues)
            {
                if (insertValues.Length > 0)
                {
                    insertFields += ", ";
                    insertValues += ", ";
                }
                insertFields += $"{kvp.Value.field}";
                insertValues += $"{kvp.Value.pvalue}";
                Parameters.Add(new SqlParameter(kvp.Value.pvalue, kvp.Value.value));
            }
            string query = string.Format(
                sqlQueries[ESqlQueries.INSERT], insertFields, insertValues);
            return ExecuteQuery(query, ESqlQueries.INSERT,Parameters);
        }

        // Update
        public int UpdateByEntity(TEntity entity)
        {
            string updateValues = string.Empty;
            IDictionary<Enum, (string field, string pvalue, dynamic value)> entityValues = GetKeyFieldsValues(entity);
            entityValues.Remove(EIEntity.ID);
            List<SqlParameter> Parameters = new List<SqlParameter>();
            foreach (KeyValuePair<Enum, (string field, string pvalue, dynamic value)> kvp in entityValues)
            {
                if (updateValues.Length > 0)
                {
                    updateValues += ", ";
                }
                updateValues += $"{kvp.Value.field} = {kvp.Value.pvalue}";
                Parameters.Add(new SqlParameter(kvp.Value.pvalue, kvp.Value.value));
            }
            Parameters.Add(new SqlParameter("@id", entity.ID));
            string query = string.Format(sqlQueries[ESqlQueries.UPDATE_BY_ID], updateValues, GetTableField("id"));
            return ExecuteQuery(query, ESqlQueries.UPDATE_BY_ID,Parameters);
        }

        public int UpdateByFieldName(string fieldName, dynamic text, string fieldCondition, dynamic textCondition)
        {
            List<SqlParameter> Parameters = new List<SqlParameter>() { new SqlParameter("@value", text),new SqlParameter("@condition", textCondition)};
            return ExecuteQuery(string.Format( sqlQueries[ESqlQueries.UPDATE_BY_FIELD],GetTableField(fieldName),GetTableField(fieldCondition)), ESqlQueries.UPDATE_BY_FIELD, Parameters);
        }

        // Delete
        public int DeleteById(long id)
        {
            List<SqlParameter> Parameters = new List<SqlParameter>()
            { new SqlParameter("@id", id) };
            return ExecuteQuery(string.Format(sqlQueries[ESqlQueries.DELETE_BY_ID],GetTableField("id")), ESqlQueries.DELETE_BY_ID, Parameters);
        }

        public int DeleteByFieldName(string fieldCondition, dynamic textCondition)
        {
            List<SqlParameter> Parameters = new List<SqlParameter>()
            { new SqlParameter("@value", textCondition) };
            return ExecuteQuery(string.Format(sqlQueries[ESqlQueries.DELETE_BY_FIELD], GetTableField(fieldCondition)), ESqlQueries.DELETE_BY_FIELD, Parameters);
        }

        public int Delete(TEntity entity)
        {
            return DeleteById(entity.ID.Value);
        }
    }
}
