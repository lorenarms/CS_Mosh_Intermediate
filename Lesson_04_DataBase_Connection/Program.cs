using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_DataBase_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbCommand = "null";
            
            var newOrConnection = new OracleConnection();
            var newSQLConnection = new SqlConnection();

            dbCommand = "Oracle Command";

            DBCommand.Execute(newOrConnection, dbCommand);

            dbCommand = "SQL Command";
            DBCommand.Execute(newSQLConnection, dbCommand);

            


            Console.ReadKey();
        }
    }
}
