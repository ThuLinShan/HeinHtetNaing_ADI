namespace HeinHtetNaing_ADI.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class SqlColumnNameAttribute : Attribute
    {
        public string ColumnName { get; }

        public SqlColumnNameAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }
}
