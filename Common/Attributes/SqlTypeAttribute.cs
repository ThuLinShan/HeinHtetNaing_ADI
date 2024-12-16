namespace HeinHtetNaing_ADI.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class SqlTypeAttribute : Attribute
    {
        public string SqlType { get; }

        public SqlTypeAttribute(string sqlType)
        {
            SqlType = sqlType;
        }
    }
}
