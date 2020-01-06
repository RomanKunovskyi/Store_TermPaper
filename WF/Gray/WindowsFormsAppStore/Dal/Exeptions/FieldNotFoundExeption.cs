using System;

namespace Dal.Exceptions
{
    public class FieldNotFoundExeption : Exception
    {
        public FieldNotFoundExeption(string fieldName) : base(string.Format("Field Not Found {0}", fieldName)) { }
        public FieldNotFoundExeption() : base() { }
    }
}
