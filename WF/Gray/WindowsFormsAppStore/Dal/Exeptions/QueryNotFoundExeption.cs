using System;

namespace Dal.Exceptions
{
    public class QueryNotFoundExeption:Exception
    {
        public QueryNotFoundExeption(string queryName) : base(string.Format("Empty DataReader by Query {0}", queryName)) { }
        public QueryNotFoundExeption() : base() { }
    }
}
