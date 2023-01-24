using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public override void Close()
        {
            Console.WriteLine("Closing SQL Server connection...");
        }

        public override void Open()
        {
            Console.WriteLine("Opening SQL Server connection...");
        }
    }
}
