using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string CommandText { get; set; }
        public DbCommand(DbConnection connection, string commandText)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection) + " is null");
            if (String.IsNullOrWhiteSpace(commandText))
                throw new FormatException("Command Text is not in the right format");
            Connection = connection;
            CommandText = commandText;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("Executing the command {0}...", CommandText);
            Connection.Close();
        }
    }
}
