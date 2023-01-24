using System;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString): base(connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection...");
        }
    }
}
