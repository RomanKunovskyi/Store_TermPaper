using System;

namespace Dal.Exceptions
{
    class EmptyDataReaderByQueryExeption:Exception
    {
        public EmptyDataReaderByQueryExeption(string queryName) : base(string.Format("Query not found {0}", queryName)) { }
        public EmptyDataReaderByQueryExeption() : base() { }
    }
}
