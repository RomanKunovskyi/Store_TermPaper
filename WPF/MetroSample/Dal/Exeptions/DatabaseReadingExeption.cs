using System;

namespace Dal.Exceptions
{
    class DatabaseReadingExeption:Exception
    {
        public DatabaseReadingExeption(Exception e) : base("Database Reading Error",e) { }
        public DatabaseReadingExeption() : base() { }
    }
}
