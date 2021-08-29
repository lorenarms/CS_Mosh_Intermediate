using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_DataBase_Connection
{
    public abstract class DBConnection
    {
        public string ConnectionString;
        public TimeSpan Timeout;
        public DateTime ConnectionTime;

        public abstract void OpenConnection(string connection);
        public abstract void CloseConnection();

    }

    class SqlConnection : DBConnection
    {
        
        public override void CloseConnection()
        {
            //throw new NotImplementedException();
            Timeout = DateTime.Now - ConnectionTime;
            Console.WriteLine("Time connected: " + Timeout);
            Console.WriteLine("SQL Connection Closed");

        }

        public override void OpenConnection(string connection)
        {
            if (connection == "null")
            {
                Console.WriteLine("Invalid connection, aborting.");
                return;
            }
            Console.WriteLine("SQL Connection started...");
            ConnectionString = connection;
            ConnectionTime = DateTime.Now;
           
            //throw new NotImplementedException();
        }
    }

    class OracleConnection : DBConnection
    {
        public override void CloseConnection()
        {
            Timeout = DateTime.Now - ConnectionTime;
            Console.WriteLine("Time connected: " + Timeout);
            Console.WriteLine("Oracle Connection Closed");
            //throw new NotImplementedException();
        }

        public override void OpenConnection(string connection)
        {
            if (connection == "null")
            {
                Console.WriteLine("Invalid connection, aborting.");
                return;
            }

            Console.WriteLine("Oracle connection started...");
            ConnectionString = connection;
            ConnectionTime = DateTime.Now;
        }
    }


}
