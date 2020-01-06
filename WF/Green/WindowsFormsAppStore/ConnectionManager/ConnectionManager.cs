using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace ConnectionManager
{
    public sealed class ConnectionManager
    {
        private static volatile ConnectionManager instance = null;

        private readonly string connectionString;
        private readonly IDictionary<int, SqlConnection> connections;

        private ConnectionManager(string connectionString)
        {
            this.connectionString = connectionString;
            connections = new Dictionary<int, SqlConnection>();
        }

        public static ConnectionManager Get()
        {
            return Get(null);
        }

        public static ConnectionManager Get(string connectionString)
        {
            if (instance == null)
            {
                lock (typeof(ConnectionManager))
                {
                    if (instance == null)
                    {
                        if (connectionString == null)
                        {
                            connectionString = ConnectionRepository.ConnectionRepository.GetDefaultConnectionString();
                        }
                        instance = new ConnectionManager(connectionString);
                    }
                }
            }
            return instance;
        }

        public static void CloseConnections()
        {
            SqlConnection connection;
            foreach (KeyValuePair<int, SqlConnection> kvp in Get().connections)
            {
                connection = Get().connections[kvp.Key];
                if ((connection != null) && (connection.State == ConnectionState.Open))
                {
                    connection.Close();
                }
                Get().connections.Add(kvp.Key, null);
            }
        }

        public SqlConnection GetConnection()
        {
            SqlConnection connection;
            connections.TryGetValue(Thread.CurrentThread.ManagedThreadId, out connection);
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connections.Add(Thread.CurrentThread.ManagedThreadId, connection);
            }
            return connection;
        }
    }
}
