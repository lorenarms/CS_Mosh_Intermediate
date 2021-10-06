using System;

namespace Lesson_07_DB_Interface
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)       //dependency injection
        {
            _logger = logger;
        }
        public void Migrate()

        {
            _logger.LogInfo("Migrating started at " + DateTime.Now);


            // Details of migrating the database

            _logger.LogInfo("Migrating finished at " + DateTime.Now);
            
        }
    }
}
