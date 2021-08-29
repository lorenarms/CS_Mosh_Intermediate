using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_DataBase_Connection
{
    class DBCommand
    {
        public static void Execute(DBConnection connection, string command)
        {
            if (connection.Equals("null"))
            {
                Console.WriteLine("Invalid connection type; aborting connection.");
            }
            if (command.Equals("null"))
            {
                Console.WriteLine("Invalid command; aborting connection.");
            }
            connection.OpenConnection(connection.ConnectionString);
            Console.WriteLine("Sending instuctions to DB: " + command);
            connection.CloseConnection();
        }
    }
}
