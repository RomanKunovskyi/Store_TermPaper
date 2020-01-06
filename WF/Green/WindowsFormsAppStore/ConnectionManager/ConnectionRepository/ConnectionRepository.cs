namespace ConnectionManager.ConnectionRepository
{
    public sealed class ConnectionRepository
    {
        private ConnectionRepository()
        {
        }

        public static string GetDefaultConnectionString()
        {
            return GetLocalConnectionString();
        }

        public static string GetLocalConnectionString()
        {
            return "Data Source=DESKTOP-9MS6PJH;Initial Catalog=Shop;Integrated Security=SSPI";
        }
    }
}
