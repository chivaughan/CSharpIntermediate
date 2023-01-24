
using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new OracleConnection("Oracle ConnStr");
            string commandText = @"SELECT * FROM Employees";
            var dbCommand = new DbCommand(connection, commandText);
            dbCommand.Execute();
        }
    }
}
