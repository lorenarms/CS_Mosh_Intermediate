using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_DB_Interface
{

    class Program
    {

        
        static void Main(string[] args)
        {
            var dbMigrator01 = new DbMigrator(new ConsoleLogger());
            var dbMigrator02 = new DbMigrator(new FileLogger("C:\\Users\\dayar\\Desktop\\log.txt"));


            dbMigrator01.Migrate();
            dbMigrator02.Migrate();


            Console.ReadKey();
        }

        
    }
}
